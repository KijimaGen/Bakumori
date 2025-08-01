/**
 * @file GameConst.cs
 * @brief ゲームの定数
 * @author Sum1r3
 * @date 2025/7/30
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConst{
    
    //ゲームパート
    public enum MainGameState {
        Invalid  = -1,
        Start = 0,
        Main = 1,
        Result = 2,
    }
    //ゲームパートの数
    public const int PART_MAX = 3;
}
