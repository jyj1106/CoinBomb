using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowtoPlay : MonoBehaviour
{
    public GameObject howpanel;

    public void Open()
    {
        if(howpanel.activeSelf == false)
        {
            howpanel.SetActive(true);
        }
    }

    public void Close()
    {
        if(howpanel.activeSelf == true)
        {
            howpanel.SetActive(false);
        }
    }
}
