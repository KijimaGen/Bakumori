/**
 * @file SystemObject.cs
 * @brief ‚»‚ê‚¼‚ê‚Ì‹@”\‚ÌŠÇ—Ò‚ÌŠî’ê
 * @author Sum1r3
 * @date 2025/7/30
 */
using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SystemObject : MonoBehaviour{

    /// <summary>
    /// ‰Šú‰»ˆ—
    /// </summary>
    /// <returns></returns>
    public abstract UniTask Initialize();
}
