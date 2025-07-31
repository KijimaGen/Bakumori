/**
 * @file PartBase.cs
 * @brief �e�p�[�g�̏������Ăяo���I�u�W�F�N�g�̊��N���X
 * @author Sum1r3
 * @date 2025/7/31
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PartBase : MonoBehaviour{

    //����������
    public abstract void Initialize();

    //�p�[�g���̏���
    public abstract void PartProcess();

    //�p�[�g�J�n���̏���
    public abstract void MyPartStart();

    //�p�[�ƏI�����̏���
    public abstract void Teardown();

}
