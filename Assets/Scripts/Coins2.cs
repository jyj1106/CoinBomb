using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins2 : MonoBehaviour
{
    private Animator anim;
    public float moveSpeed = -1f;
    public AudioSource eat;
    private float delayTime = 2.5f;
    public static float coin = 50f;
    // Start is called before the first frame update

    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        Destroy(this.gameObject, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-moveSpeed * Time.deltaTime, 0f, 0f);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.CompareTag("Player"))
        {
            anim.SetBool("isCollide", true);
            Destroy(this.gameObject, delayTime);
            coin++;
            eat.Play();
        }
    }
}
