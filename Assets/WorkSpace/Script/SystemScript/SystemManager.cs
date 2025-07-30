/**
 * @file SystemManager.cs
 * @brief �Q�[���S�̂Ŏg�p����@�\�̊Ǘ�
 * @author Sum1r3
 * @date 2025/7/30
 */
using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour{
    /// <summary>
    /// �V�X�e���}�l�[�W���[�B
    /// </summary>
    [SerializeField]
    private List<SystemObject> _systemObjectList = null;

    private void Awake() {
        //���������������s
        UniTask task = Initialize();
    }

    

    private async UniTask Initialize() {
        for(int i = 0, max  = _systemObjectList.Count; i < max; i++) {
            SystemObject origin = _systemObjectList[i];
            if (origin == null) continue;
            //�V�X�e���I�u�W�F�N�g����
            SystemObject createObject = Instantiate(origin,transform);
            //������
            await createObject.Initialize();
        }
        //��v�A�C�e��������̏��������s
    }
}
