/**
 * @file Player.cs
 * @brief �v���C���[�����삷��L�����N�^�[
 * @author Sum1r3
 * @date 2025/7/30
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : CharacterBase {
    //player�̓��͂��Ǘ�
    private PlayerInputAction _inputActions;
    //���g�̈ړ��X�s�[�h
    private float _moveSpeed = 1.0f;
    //�ړ��̓��͎�t
    private Vector2 _moveInput;
    
    //unity�̃L�����N�^�[�R���g���[���[
    private CharacterController _controller;

    private void Awake() {
        Initialize();
    }

    /// <summary>
    /// ����������
    /// </summary>
    public override void Initialize() {
        _inputActions = new PlayerInputAction();
        _controller = GetComponent<CharacterController>();
    }

    /// <summary>
    /// �X�N���v�g���L���ɂȂ����Ƃ��ɌĂ΂����͂̎�t
    /// </summary>
    private void OnEnable() {
        //���͎�t���J�n
        _inputActions.Enable();

        //���͂��ꂽ�Ƃ��̃C�x���g�o�^
        _inputActions.Player.Move.performed += ctx => _moveInput = ctx.ReadValue<Vector2>();
        //���͂���Ȃ������Ƃ��̃C�x���g����
        _inputActions.Player.Move.canceled += ctx => _moveInput = Vector2.zero;

    }

    /// <summary>
    /// �X�N���v�g�������ɂȂ����Ƃ��ɌĂ΂��
    /// </summary>
    private void OnDisable() {

        //�C�x���g�̓o�^����(���������[�N�E�d���o�^�֎~)
        _inputActions.Player.Move.performed -= ctx => _moveInput = ctx.ReadValue<Vector2>();
        _inputActions.Player.Move.canceled -= ctx => _moveInput = Vector2.zero;

        //���͎�t���~
        _inputActions.Disable();
    }

    private void Update() {
        //�n�ʂɉ������ړ�
        Vector3 move = new Vector3(_moveInput.x, 0, _moveInput.y);
        _controller.Move(move*_moveSpeed*Time.deltaTime);

    }

}
