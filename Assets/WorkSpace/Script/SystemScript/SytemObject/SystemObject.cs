/**
 * @file SystemObject.cs
 * @brief ���ꂼ��̋@�\�̊Ǘ��҂̊��
 * @author Sum1r3
 * @date 2025/7/30
 */
using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SystemObject : MonoBehaviour{

    /// <summary>
    /// ����������
    /// </summary>
    /// <returns></returns>
    public abstract UniTask Initialize();
}
