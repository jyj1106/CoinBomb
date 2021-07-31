using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public void GoTitleScene()
    {
        SceneManager.LoadScene("1.Title");
    }
    public void GoSelectScene()
    {
        SceneManager.LoadScene("2.Select");
    }
    public void GoGameScene1()
    {
        SceneManager.LoadScene("RedSlime");
    }

    public void GoGameScene2()
    {
        SceneManager.LoadScene("YellowSlime");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
