using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesale : MonoBehaviour
{
    Vector3 Anoktasi = new Vector3(-0.1f, 0, 0);
    Vector3 Bnoktasi = new Vector3(0.1f, 0, 0);
    float hiz = 10f;
    float t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * hiz;
        transform.position = Vector3.Lerp(Anoktasi, Bnoktasi, t);
        if (t >= 1)
        {
            var b = Bnoktasi;
            var a = Anoktasi;
            Anoktasi = b;
            Bnoktasi = a;
            t = 0;
        }
    }
}
