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
    //呼び出し用のパート
    [SerializeField]
    private List<PartBase> parts = new List<PartBase>(PART_MAX);

    //管理用のパート
    private List<PartBase> partList = new List<PartBase>(PART_MAX);

    public override async UniTask Initialize() {
        instance = this;
        

        //パートを生成して初期化
        for(int i  = 0; i < parts.Count; i++) {
            PartBase part = parts[i];
            Instantiate(part, transform);
            part.Initialize();
            part.gameObject.SetActive(false);
            //パートリストに追加、これで参照を持てる
            partList.Add(part);
        }

        //ゲームを開始状態にしておく<-今はメインゲーム中にしておくよん
        mainGameState = MainGameState.Main;
        await ChangeGamePart(mainGameState);

        //作業完了待ち
        await UniTask.CompletedTask;
    }

    /// <summary>
    /// それぞれの処理をアップデートで呼び出す
    /// </summary>
    private void Update() {
        if (partList.Count < 3) return;

        switch (mainGameState) {
            case MainGameState.Invalid:
                break;
            case MainGameState.Start:
                break;
            case MainGameState.Main:
                partList[1].PartProcess();
                break;
            case MainGameState.Result:
                break;
        }
    }

    

    public async UniTask ChangeGamePart(MainGameState changeState) {
        //先に今のパートを不活性化
        partList[(int) mainGameState].gameObject.SetActive(false);
        //現在のゲームステートを書き換え
        mainGameState = changeState;
        //変わった先のゲームステートをアクティブに
        partList[(int)mainGameState].gameObject.SetActive(true);
        partList[(int)mainGameState].MyPartStart();

        await UniTask.CompletedTask;
    }

}
