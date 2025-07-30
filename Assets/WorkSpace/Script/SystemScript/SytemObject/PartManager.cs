/**
 * @file PartManager.cs
 * @brief �p�[�g�Ǘ���
 * @author Sum1r3
 * @date 2025/7/30
 */
using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static GameConst;

public class PartManager : SystemObject{
    //���g�ւ̎Q��
    public static PartManager instance;
    //�Q�[���X�e�[�g���Ǘ�
    public MainGameState mainGameState { get; private set; }

    public override async UniTask Initialize() {
        instance = this;
        //�Q�[�����J�n��Ԃɂ��Ă���
        mainGameState = MainGameState.Start;
        //1�t���҂�
        await UniTask.Delay(1);
    }

}
