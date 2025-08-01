using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : CharacterBase{
    //‚¢‚¿‚Î‚ñ‹ß‚­‚ÌÈ
    [SerializeField]
    private GameObject NearestSheet;

    public override void Initialize() {

    }

    public async void Start() {
         await CustomerMove();
        
    }

    /// <summary>
    /// ‚¢‚¿‚Î‚ñ‹ß‚­‚ÌÈ‚ÉŒü‚©‚Á‚ÄˆÚ“®
    /// </summary>
    /// <returns></returns>
    private async UniTask CustomerMove() {
        
    }

    /// <summary>
    /// ‚¢‚¿‚Î‚ñ‹ß‚­‚ÌÈ‚ğ’T‚·
    /// </summary>
    public void SarchNearestSheet() {

    }
}
