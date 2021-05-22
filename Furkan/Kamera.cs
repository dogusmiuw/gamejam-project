using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    Transform m_Player;

    // Start is called before the first frame update
    void Start()
    {
        m_Player = GameObject.FindGameObjectWithTag("Player").transform;//oyuncuyu player tagına bağladık

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mypos = transform.position;//kameranın posizyonu
        Vector3 targetpos = m_Player.position;//oyuncunun pozisyonu 
        mypos.x = targetpos.x;//x ekseninde taip etmesini sağladık
        mypos.y = targetpos.y;//burada oyuncunun y pozisyonu kameranın y pozisyonuna atıyoruz
        transform.position = mypos;//burada da o konuma taşıyoruz
    }
   
}