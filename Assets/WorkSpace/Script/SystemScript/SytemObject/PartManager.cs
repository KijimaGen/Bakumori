/**
 * @file PartManager.cs
 * @brief パート管理者
 * @author Sum1r3
 * @date 2025/7/30
 */
using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static GameConst;

public class PartManager : SystemObject{
    //自身への参照
    public static PartManager instance;
    //ゲームステートを管理
    public MainGameState mainGameState { get; private set; }

    public override async UniTask Initialize() {
        instance = this;
        //ゲームを開始状態にしておく
        mainGameState = MainGameState.Start;
        //1フレ待ち
        await UniTask.Delay(1);
    }

}
