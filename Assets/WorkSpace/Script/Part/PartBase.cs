/**
 * @file PartBase.cs
 * @brief 各パートの処理を呼び出すオブジェクトの基底クラス
 * @author Sum1r3
 * @date 2025/7/31
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PartBase : MonoBehaviour{

    //初期化処理
    public abstract void Initialize();

    //パート毎の処理
    public abstract void PartProcess();

    //パート開始時の処理
    public abstract void MyPartStart();

    //パーと終了時の処理
    public abstract void Teardown();

}
