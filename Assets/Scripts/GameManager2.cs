using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour
{
    public Text scoreText;
    public GameObject resultpanel;
    private float score = 0f;
    private float score2 = 50f;
    public Text yourscore;
    public AudioSource bgm;
    public AudioClip[] bgmclip;
    /*
    private int bestscore = 0;
    public Text highscore;
    */

    public void AddScore(int num)
    {
        score2 += num;
        scoreText.text = "Coin : 0" + score2;
    }

    // Start is called before the first frame update
    void Start()
    {
        bgm.clip = bgmclip[Random.Range(0, bgmclip.Length)];
        bgm.Play();
        Coins2.coin = 50;
        Obstacles.moveSpeed = 5;
        Obstacles2.moveSpeed = -5;
        BombSpawn.spawnDelay = (float)2.5f;
        BGScroller2.scrollSpeed = (float)0.5f;
        BGScroller3.scrollSpeed = -(float)0.5f;
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
        AddScore(0);
        score = Coins.coin;
        score2 = Coins2.coin;
        if(RedSlime.life == true)
        {
            scoreText.text = "Score : " + score;
        }
        if (YellowSlime.life == true)
        {
            scoreText.text = "Score : " + score2;
        }
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
        if(YellowSlime.life == false)
        {
            int result2 = (int)Coins2.coin;
            yourscore.text = "My Score : " + result2;
        }
    }
}
