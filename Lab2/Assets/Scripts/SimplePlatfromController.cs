using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlatfromController : MonoBehaviour
{

    public bool facingRight = true;
    public bool jump = false;
    public int score;
    public GameObject scoreCounter;

    private int scorePoint;
    public float moveForce = 365;
    public float maxSpeed = 5;
    public float jumpForce = 1000;
    public Transform groundCheck;

    private bool grounded = false;
    private Animator anim;
    private Rigidbody2D rb2d;

   
    private void Awake()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        if(Input.GetButtonDown("Jump") && grounded)
        {
            jump = true;

        }
    }

    //void Flip()
    //{
    //    facingRight = !facingRight;

    //}

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        //anim.SetFloat("Speed", Mathf.Abs(h));

        if (h*rb2d.velocity.x < maxSpeed)
        {
            rb2d.AddForce(Vector2.right * h * moveForce);
        }

        if (Mathf.Abs(rb2d.velocity.x) > maxSpeed)
        {
            rb2d.velocity = new Vector2(Mathf.Sign(rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);

        }

        if (jump)
        {
            //anim.SetTrigger("Jump");
            {
                rb2d.AddForce(new Vector2(0, jumpForce));
                jump = false;
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PickUpV1"))
        {
            Destroy(collision.gameObject);
            scorePoint = 1;
            scoreCounter.GetComponent<ScoreCounter>().AddScore(scorePoint);
        }
        if (collision.gameObject.CompareTag("PickUpV2"))
        {
            Destroy(collision.gameObject);
            scorePoint = 4;
            scoreCounter.GetComponent<ScoreCounter>().AddScore(scorePoint);
        }

        scorePoint = 0;
    }
}
