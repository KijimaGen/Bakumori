/**
 * @file Player.cs
 * @brief プレイヤーが操作するキャラクター
 * @author Sum1r3
 * @date 2025/7/30
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : CharacterBase {
    //playerの入力を管理
    private PlayerInputAction _inputActions;
    //自身の移動スピード
    private float _moveSpeed = 2.0f;
    //移動の入力受付
    private Vector2 _moveInput;
    
    //unityのキャラクターコントローラー
    private CharacterController _controller;

    

    /// <summary>
    /// 初期化処理
    /// </summary>
    public override void Initialize() {
        
        
    }

    /// <summary>
    /// スクリプトが有効になったときに呼ばれる入力の受付
    /// </summary>
    private void Awake() {

        _inputActions = new PlayerInputAction();
        _controller = GetComponent<CharacterController>();
        //入力受付を開始
        _inputActions.Enable();

        //入力されたときのイベント登録
        _inputActions.Player.Move.performed += ctx => _moveInput = ctx.ReadValue<Vector2>();
        //入力されなかったときのイベント解除
        _inputActions.Player.Move.canceled += ctx => _moveInput = Vector2.zero;

    }

    /// <summary>
    /// スクリプトが無効になったときに呼ばれる
    /// </summary>
    private void OnDisable() {

        //イベントの登録解除(メモリリーク・重複登録禁止)
        _inputActions.Player.Move.performed -= ctx => _moveInput = ctx.ReadValue<Vector2>();
        _inputActions.Player.Move.canceled -= ctx => _moveInput = Vector2.zero;

        if(_inputActions != null)
        //入力受付を停止
        _inputActions.Disable();
    }

    /// <summary>
    /// プレイヤーの行動
    /// </summary>
    private void Update() {
        
        //地面に沿った移動
        Vector3 move = new Vector3(_moveInput.x, 0, _moveInput.y);
        _controller.Move(move * _moveSpeed * Time.deltaTime);
    }

}
