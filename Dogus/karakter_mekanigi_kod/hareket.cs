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
        float scale = transform.localScale.x;

        float yatay = Input.GetAxis("Horizontal");
        transform.position += new Vector3(yatay*hiz,0,0);

        if(yatay > 0)
        {
            transform.localScale = new Vector3(scale, scale, 1);
            
        } else if(yatay < 0)
        {
            transform.localScale = new Vector3(scale*-1, scale, 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Mesale temas");
    }

    void Update()
    {
        
    }
}
