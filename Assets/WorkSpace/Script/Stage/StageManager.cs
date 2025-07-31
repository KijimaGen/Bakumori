/**
 * @file StageManager.cs
 * @brief ステージを作成
 * @author Sum1r3
 * @date 2025/7/30
 */

using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class StageManager : SystemObject{
    [SerializeField]
    private GameObject _originBlock;

    //ステージの立幅横幅
    private const int STAGE_WIDTH_MAX = 14;
    private const int STAGE_HEIGHT_MAX = 10;
    //ブロック間の幅
    private const int SPACE = 1;

    //自身のインスタンス
    public static StageManager instance;

    /// <summary>
    /// 初期化処理
    /// </summary>
    public override async UniTask Initialize() {
        instance = this;
        BuildStage();
        await UniTask.Delay(1);
    }

    /// <summary>
    /// ステージ作成
    /// </summary>
    public void BuildStage() {
        if (_originBlock == null) return;
        //二つの配列で二次元上のステージを作成
        for(int x = 0; x < STAGE_WIDTH_MAX; x++) {
            for(int z = 0; z < STAGE_HEIGHT_MAX; z++) {
                //ブロックを置く座標をキャッシュ
                Vector3 instantiatePos = new Vector3(x * SPACE, this.transform.position.y, z * SPACE);
                Instantiate(_originBlock,instantiatePos,Quaternion.identity,transform);
            }
        }
    }

   
}
