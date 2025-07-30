/**
 * @file SystemManager.cs
 * @brief ゲーム全体で使用する機能の管理
 * @author Sum1r3
 * @date 2025/7/30
 */
using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour{
    /// <summary>
    /// システムマネージャー達
    /// </summary>
    [SerializeField]
    private List<SystemObject> _systemObjectList = null;

    private void Awake() {
        //初期化処理を実行
        UniTask task = Initialize();
    }

    

    private async UniTask Initialize() {
        for(int i = 0, max  = _systemObjectList.Count; i < max; i++) {
            SystemObject origin = _systemObjectList[i];
            if (origin == null) continue;
            //システムオブジェクト生成
            SystemObject createObject = Instantiate(origin,transform);
            //初期化
            await createObject.Initialize();
        }
        //主要アイテム生成後の処理を実行
    }
}
