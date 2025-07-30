/**
 * @file CharacterBase.cs
 * @brief キャラクターの基底
 * @author Sum1r3
 * @date 2025/7/30
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterBase : MonoBehaviour{

    /// <summary>
    /// 初期化
    /// </summary>
    public abstract void Initialize();

    /// <summary>
    /// 移動(一応書き換え可能にしておく)
    /// </summary>
    /// <param name="moveValue"></param>
    public virtual void Move(Vector3 moveValue) {
        transform.position += moveValue;
    }
}
