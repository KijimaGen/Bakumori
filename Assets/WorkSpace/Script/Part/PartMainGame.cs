/**
 * @file PartMainGame.cs
 * @brief メインゲーム処理だよん
 * @author Sum1r3
 * @date 2025/7/31
 */
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PartMainGame : PartBase {
    //playerを持っておくよん
    [SerializeField]
    private Player player;
    //何度も使うのでプレイヤーを取っておく
    private Player _player;

    //プレイヤーの呼び出し座標
    private readonly Vector3 PLAYER_SPAWN_POS = new Vector3(0,2,0);

    /// <summary>
    /// 初期化
    /// </summary>
    public override void Initialize() {
        _player = player;
    }

    /// <summary>
    /// パートの処理
    /// </summary>
    public override void PartProcess() {
        
    }

    /// <summary>
    /// パート開始時処理
    /// </summary>
    public override void MyPartStart() {
        
        //プレイヤーの召喚
        Instantiate(_player,PLAYER_SPAWN_POS,Quaternion.identity);
        _player.Initialize();
    }

    //パート終了時の処理
    public override void Teardown() {
       
    }
}
