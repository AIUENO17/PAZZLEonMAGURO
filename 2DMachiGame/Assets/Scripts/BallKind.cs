using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallKind : MonoBehaviour
{
    public enum Ballkind // ゲーム内にて利用するピースの種類
    {
        FireBall = 0,    // 火
        WaterBall,       // 水
        WindBall,      // 緑
        LightBall,     // 光
        DarkBall,      // 闇
        PinkBall,    // 回復
    }
}