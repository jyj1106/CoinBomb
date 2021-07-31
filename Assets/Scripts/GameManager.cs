using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject resultpanel;
    private float score = 0f;
    public Text yourscore;
    public AudioSource bgm;
    public AudioClip[] bgmclip;
    /*
    private int bestscore = 0;
    public Text highscore;
    */

    public void AddScore(int num)
    {
        score += num;
        scoreText.text = "Coin : 0" + score;
    }

    // Start is called before the first frame update
    void Start()
    {
        bgm.clip = bgmclip[Random.Range(0, bgmclip.Length)];
        bgm.Play();
        Coins.coin = 0;
        Obstacles.moveSpeed = 5;
        BombSpawn.spawnDelay = (float)2.5f;
        BGScroller2.scrollSpeed = (float)0.5f;
        /*
        if (PlayerPrefs.HasKey("HighScore"))
        {
            bestscore = PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            bestscore = 100;
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        score = Coins.coin;
        scoreText.text = "Score : " + score;
        if(RedSlime.life == false)
        {
            int result = (int)Coins.coin;
            yourscore.text = "My Score : " + result;
            /*
            highscore.text = "High Score : " + bestscore;
            if(result > bestscore)
            {
                PlayerPrefs.SetInt("HighScore", result);
            }
            */
        }
    }
}
