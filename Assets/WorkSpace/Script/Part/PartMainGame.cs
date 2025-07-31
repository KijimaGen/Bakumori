/**
 * @file PartMainGame.cs
 * @brief ���C���Q�[�����������
 * @author Sum1r3
 * @date 2025/7/31
 */
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PartMainGame : PartBase {
    //player�������Ă������
    [SerializeField]
    private Player player;
    //���x���g���̂Ńv���C���[������Ă���
    private Player _player;

    //�v���C���[�̌Ăяo�����W
    private readonly Vector3 PLAYER_SPAWN_POS = new Vector3(0,2,0);

    /// <summary>
    /// ������
    /// </summary>
    public override void Initialize() {
        _player = player;
    }

    /// <summary>
    /// �p�[�g�̏���
    /// </summary>
    public override void PartProcess() {
        
    }

    /// <summary>
    /// �p�[�g�J�n������
    /// </summary>
    public override void MyPartStart() {
        
        //�v���C���[�̏���
        Instantiate(_player,PLAYER_SPAWN_POS,Quaternion.identity);
        _player.Initialize();
    }

    //�p�[�g�I�����̏���
    public override void Teardown() {
       
    }
}
