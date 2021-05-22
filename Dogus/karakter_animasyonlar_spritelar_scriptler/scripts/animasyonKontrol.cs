using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animasyonKontrol : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    { 
        
        if (ziplama.FindObjectOfType<Rigidbody2D>().velocity.y < 0)
        {
            anim.SetBool("isFalling", true);
        }
        else
        {
            //if(ziplama.yerdeMi)
            //{
                anim.SetBool("isFalling", false);
            //}
        }
        
        if(Input.GetKey("d") || Input.GetKey("a"))
        {
            anim.SetBool("isRunning",true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

    }
}
