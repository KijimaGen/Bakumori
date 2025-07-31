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
    //�Ăяo���p�̃p�[�g
    [SerializeField]
    private List<PartBase> parts = new List<PartBase>(PART_MAX);

    //�Ǘ��p�̃p�[�g
    private List<PartBase> partList = new List<PartBase>(PART_MAX);

    public override async UniTask Initialize() {
        instance = this;
        

        //�p�[�g�𐶐����ď�����
        for(int i  = 0; i < parts.Count; i++) {
            PartBase part = parts[i];
            Instantiate(part, transform);
            part.Initialize();
            part.gameObject.SetActive(false);
            //�p�[�g���X�g�ɒǉ��A����ŎQ�Ƃ����Ă�
            partList.Add(part);
        }

        //�Q�[�����J�n��Ԃɂ��Ă���<-���̓��C���Q�[�����ɂ��Ă������
        mainGameState = MainGameState.Main;
        await ChangeGamePart(mainGameState);

        //��Ɗ����҂�
        await UniTask.CompletedTask;
    }

    /// <summary>
    /// ���ꂼ��̏������A�b�v�f�[�g�ŌĂяo��
    /// </summary>
    private void Update() {
        if (partList.Count < 3) return;

        switch (mainGameState) {
            case MainGameState.Invalid:
                break;
            case MainGameState.Start:
                break;
            case MainGameState.Main:
                partList[1].PartProcess();
                break;
            case MainGameState.Result:
                break;
        }
    }

    

    public async UniTask ChangeGamePart(MainGameState changeState) {
        //��ɍ��̃p�[�g��s������
        partList[(int) mainGameState].gameObject.SetActive(false);
        //���݂̃Q�[���X�e�[�g����������
        mainGameState = changeState;
        //�ς������̃Q�[���X�e�[�g���A�N�e�B�u��
        partList[(int)mainGameState].gameObject.SetActive(true);
        partList[(int)mainGameState].MyPartStart();

        await UniTask.CompletedTask;
    }

}
