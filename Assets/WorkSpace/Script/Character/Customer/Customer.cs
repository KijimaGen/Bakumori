using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : CharacterBase{
    //�����΂�߂��̐�
    [SerializeField]
    private GameObject NearestSheet;

    public override void Initialize() {

    }

    public async void Start() {
         await CustomerMove();
        
    }

    /// <summary>
    /// �����΂�߂��̐ȂɌ������Ĉړ�
    /// </summary>
    /// <returns></returns>
    private async UniTask CustomerMove() {
        
    }

    /// <summary>
    /// �����΂�߂��̐Ȃ�T��
    /// </summary>
    public void SarchNearestSheet() {

    }
}
