using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIncrease2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Coins2.coin == 10)
        {
            Obstacles2.moveSpeed = -6;
        }
        if (Coins2.coin == 20)
        {
            Obstacles2.moveSpeed = -7;
        }
        if (Coins2.coin == 25)
        {
            Obstacles2.moveSpeed = -8;
            BombSpawn2.spawnDelay = 2;
            BGScroller3.scrollSpeed = -1;
        }
        if (Coins2.coin == 30)
        {
            Obstacles2.moveSpeed = -8;
        }
        if (Coins2.coin == 40)
        {
            Obstacles2.moveSpeed = -9;
        }
        if (Coins2.coin == 50)
        {
            Obstacles2.moveSpeed = -10;
            BombSpawn2.spawnDelay = 1;
            BGScroller3.scrollSpeed = -2;
        }
        if (Coins2.coin == 60)
        {
            Obstacles2.moveSpeed = -11;
        }
        if (Coins2.coin == 70)
        {
            Obstacles2.moveSpeed = -12;
            BGScroller3.scrollSpeed = -3;
        }
        if (Coins2.coin == 80)
        {
            Obstacles2.moveSpeed = -13;
        }
        if (Coins2.coin == 90)
        {
            Obstacles2.moveSpeed = -14;
            BGScroller3.scrollSpeed = -4;
        }
        if (Coins2.coin == 100)
        {
            Obstacles2.moveSpeed = -15;
            BombSpawn2.spawnDelay = 1;
            BGScroller3.scrollSpeed = -5;
        }
        if (Coins2.coin == 110)
        {
            Obstacles2.moveSpeed = -16;
        }
        if (Coins2.coin == 120)
        {
            Obstacles2.moveSpeed = -17;
        }
        if (Coins2.coin == 130)
        {
            Obstacles2.moveSpeed = -18;
        }
        if (Coins2.coin == 140)
        {
            Obstacles2.moveSpeed = -19;
        }
        if (Coins2.coin == 150)
        {
            Obstacles2.moveSpeed = -20;
        }
    }

}