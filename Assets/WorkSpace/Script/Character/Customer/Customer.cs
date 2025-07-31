using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : CharacterBase
{
    public override void Initialize() {
    }

    public async void Start() {
         await CustomerMove();
        
    }

    private async UniTask CustomerMove() {
        
    }
}
