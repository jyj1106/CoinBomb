using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowSlime : MonoBehaviour
{
    private Animator anim;
    public AudioSource jump;
    public AudioSource land;
    public GameObject resultpanel;
    public float jumpPower = 300f;
    public static bool life = true;
    bool isJumping = false;
    
    // Start is called before the first frame update

    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                if (isJumping == false)
                {
                    isJumping = true;
                    anim.SetBool("isJumping", true);
                    GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpPower);
                    jump.Play();
                }
            }
            if (touch.phase == TouchPhase.Ended)
            {
                if (isJumping == true)
                {
                    anim.SetBool("isLanding", true);
                    GetComponent<Rigidbody2D>().AddForce(Vector2.down * 500);
                    land.Play();
                }
            }
        }     
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isJumping == false) 
            {
                isJumping = true;
                anim.SetBool("isJumping", true);
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpPower);
                jump.Play();
            }
        }
        if (Input.GetKeyUp(KeyCode.Space)) 
        {
            if (isJumping == true)
            {
                anim.SetBool("isLanding", true);
                GetComponent<Rigidbody2D>().AddForce(Vector2.down * 500);
                land.Play();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Ground")) 
        {
            isJumping = false;
            anim.SetBool("isJumping", false);
            anim.SetBool("isLanding", false);
        }
        if (other.transform.CompareTag("Obstacle")) 
        {
            life = false;
            Destroy(this.gameObject);
            if (resultpanel.activeSelf == false)
            {
                resultpanel.SetActive(true);
            }
        }
    }
}
