/**
 * @file CharacterBase.cs
 * @brief �L�����N�^�[�̊��
 * @author Sum1r3
 * @date 2025/7/30
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterBase : MonoBehaviour{

    /// <summary>
    /// ������
    /// </summary>
    public abstract void Initialize();

    /// <summary>
    /// �ړ�(�ꉞ���������\�ɂ��Ă���)
    /// </summary>
    /// <param name="moveValue"></param>
    public virtual void Move(Vector3 moveValue) {
        transform.position += moveValue;
    }
}
