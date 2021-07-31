using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private Animator anim;
    public AudioSource exp;
    public static float delaytime = 5f;
    public static float moveSpeed = 5f;
    // Start is called before the first frame update

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        Destroy(this.gameObject, delaytime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-moveSpeed * Time.deltaTime, 0f, 0f);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Player")) 
        {
            anim.SetBool("isCollide", true);
            gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            exp.Play();
        }
    }
}
