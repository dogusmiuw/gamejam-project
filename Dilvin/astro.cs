using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astro : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private float moveInp;

    private bool isGround;
    public Transform feetPos;
    public float checkRad;
    public LayerMask whatisGround;
    public float jumpF;

    private float jumpTimeCount;
    private float jumpTime = 0.35f;
    private bool isJumping;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    private void FixedUpdate()
    {

        float horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontal * speed, 0, 0);
        if (horizontal > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);

        }
        else if (horizontal < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }


    }
    void Update()
    {
        isGround = Physics2D.OverlapCircle(feetPos.position, checkRad, whatisGround);
        if (isGround == true && Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            jumpTimeCount = jumpTime;
            rb.velocity = Vector2.up * jumpF;
        }

        if (Input.GetKey(KeyCode.Space) && isJumping == true){
            
            if(jumpTimeCount > 0)
            {
                rb.velocity = Vector2.up * jumpF;
                jumpTimeCount -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }

        
            
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }

        RaycastHit2D collison = Physics2D.Raycast(transform.position, Vector2.down, 0.1f, whatisGround);

        if(collison.collider != null)
        {
            isGround = true;
        }
        else
        {
            isGround = false;
        }

        if(Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            rb.velocity += new Vector2(0, jumpF);
        }

    }
}