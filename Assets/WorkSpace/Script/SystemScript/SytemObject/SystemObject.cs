/**
 * @file SystemObject.cs
 * @brief それぞれの機能の管理者の基底
 * @author Sum1r3
 * @date 2025/7/30
 */
using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SystemObject : MonoBehaviour{

    /// <summary>
    /// 初期化処理
    /// </summary>
    /// <returns></returns>
    public abstract UniTask Initialize();
}
