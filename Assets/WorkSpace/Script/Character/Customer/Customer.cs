using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : CharacterBase{
    //いちばん近くの席
    [SerializeField]
    private GameObject NearestSheet;

    public override void Initialize() {

    }

    public async void Start() {
         await CustomerMove();
        
    }

    /// <summary>
    /// いちばん近くの席に向かって移動
    /// </summary>
    /// <returns></returns>
    private async UniTask CustomerMove() {
        
    }

    /// <summary>
    /// いちばん近くの席を探す
    /// </summary>
    public void SarchNearestSheet() {

    }
}
