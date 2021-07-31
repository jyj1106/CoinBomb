using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIncrease : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Coins.coin == 10)
        {
            Obstacles.moveSpeed = 6;
        }
        if (Coins.coin == 20)
        {
            Obstacles.moveSpeed = 7;
        }
        if (Coins.coin == 25)
        {
            Obstacles.moveSpeed = 8;
            BombSpawn.spawnDelay = 2;
            BGScroller2.scrollSpeed = 1;
        }
        if (Coins.coin == 30)
        {
            Obstacles.moveSpeed = 8;
        }
        if (Coins.coin == 40)
        {
            Obstacles.moveSpeed = 9;
        }
        if (Coins.coin == 50)
        {
            Obstacles.moveSpeed = 10;
            BombSpawn.spawnDelay = 1;
            BGScroller2.scrollSpeed = 2;
        }
        if (Coins.coin == 60)
        {
            Obstacles.moveSpeed = 11;
        }
        if (Coins.coin == 70)
        {
            Obstacles.moveSpeed = 12;
            BGScroller2.scrollSpeed = 3;
        }
        if (Coins.coin == 80)
        {
            Obstacles.moveSpeed = 13;
        }
        if (Coins.coin == 90)
        {
            Obstacles.moveSpeed = 14;
            BGScroller2.scrollSpeed = 4;
        }
        if (Coins.coin == 100)
        {
            Obstacles.moveSpeed = 15;
            BombSpawn.spawnDelay = 1;
            BGScroller2.scrollSpeed = 5;
        }
        if (Coins.coin == 110)
        {
            Obstacles.moveSpeed = 16;
        }
        if (Coins.coin == 120)
        {
            Obstacles.moveSpeed = 17;
        }
        if (Coins.coin == 130)
        {
            Obstacles.moveSpeed = 18;
        }
        if (Coins.coin == 140)
        {
            Obstacles.moveSpeed = 19;
        }
        if (Coins.coin == 150)
        {
            Obstacles.moveSpeed = 20;
        }
    }

}