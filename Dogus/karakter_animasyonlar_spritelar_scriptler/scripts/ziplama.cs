using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ziplama : MonoBehaviour
{
    public LayerMask layer;
    public static bool yerdeMi;
    public Rigidbody2D rb;
    public float ziplamaGucu;
    public bool doubleJump;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        RaycastHit2D carpis = Physics2D.Raycast(transform.position,Vector2.down,0.1f,layer);
        
        if(carpis.collider != null)
        {
            yerdeMi = true;
            animasyonKontrol.FindObjectOfType<Animator>().SetBool("jump",false);
        }
        else
        {
            yerdeMi = false;
            animasyonKontrol.FindObjectOfType<Animator>().SetBool("jump", true);
        }

        if(Input.GetKeyDown("w") && yerdeMi)
        {
            rb.velocity += new Vector2(0,ziplamaGucu);
            doubleJump = true;
        } else if(Input.GetKeyDown("w") && !yerdeMi && doubleJump)
        {
            rb.velocity += new Vector2(0, ziplamaGucu);
            doubleJump = false;
        }

    }

}
