using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hareket : MonoBehaviour
{
    public float hiz = 0.35f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float yatay = Input.GetAxis("Horizontal");
        transform.position += new Vector3(yatay*hiz,0,0);

        if(yatay > 0)
        {
            transform.localScale = new Vector3(0.8f, 0.8f, 1);
            
        } else if(yatay < 0)
        {
            transform.localScale = new Vector3(-0.8f, 0.8f, 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Mesale temas");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "asagiZemin")
        {
            Debug.Log("Düþtü");
            transform.position = new Vector3(-4.06f,-1.66f,0);
        }
        
    }

    void Update()
    {
        
    }
}
