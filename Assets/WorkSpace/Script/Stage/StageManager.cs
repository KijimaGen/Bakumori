/**
 * @file StageManager.cs
 * @brief �X�e�[�W���쐬
 * @author Sum1r3
 * @date 2025/7/30
 */

using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class StageManager : SystemObject{
    [SerializeField]
    private GameObject _originBlock;

    //�X�e�[�W�̗�������
    private const int STAGE_WIDTH_MAX = 14;
    private const int STAGE_HEIGHT_MAX = 10;
    //�u���b�N�Ԃ̕�
    private const int SPACE = 1;

    //���g�̃C���X�^���X
    public static StageManager instance;

    /// <summary>
    /// ����������
    /// </summary>
    public override async UniTask Initialize() {
        instance = this;
        BuildStage();
        await UniTask.Delay(1);
    }

    /// <summary>
    /// �X�e�[�W�쐬
    /// </summary>
    public void BuildStage() {
        if (_originBlock == null) return;
        //��̔z��œ񎟌���̃X�e�[�W���쐬
        for(int x = 0; x < STAGE_WIDTH_MAX; x++) {
            for(int z = 0; z < STAGE_HEIGHT_MAX; z++) {
                //�u���b�N��u�����W���L���b�V��
                Vector3 instantiatePos = new Vector3(x * SPACE, this.transform.position.y, z * SPACE);
                Instantiate(_originBlock,instantiatePos,Quaternion.identity,transform);
            }
        }
    }

   
}
