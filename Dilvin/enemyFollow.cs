using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyFollow : MonoBehaviour
{
    public int AttackTrigger2;
    public Transform Player;
    public int MoveSpeed = 4;
    public int MaxDist = 10;
    public int MinDist = 5;

    public Transform target;
    public int moveSpeed;
    public int rotationSpeed;
    public int maxDistance;

    Animator anim;

    private Transform myTransform;






    Vector3 Anoktasi = new Vector3(-2, 0, 0);
    Vector3 Bnoktasi = new Vector3(2, 0, 0);
    float hiz = 10f;
    float t;
    void Update()
    {
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





        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            {
                //Here Call any function U want Like Shoot at here or something
            }
            }
        }
    private void FixedUpdate()
    {
        Debug.DrawLine(target.position, myTransform.position, Color.yellow);



        //Look at target


        //Move towards the target, up & down
        if (target.position.y - 1 > myTransform.position.y)
        {
            myTransform.position += myTransform.up * moveSpeed * Time.deltaTime; 

            anim.SetInteger("AnimationState", 3);
        }
        else if (target.position.y + 1 < myTransform.position.y)
        {
            myTransform.position -= myTransform.up * moveSpeed * Time.deltaTime; 
        }

        //Move towards the target, right & left

        if (target.position.x + 0.05f < myTransform.position.x)
        {
            myTransform.position -= myTransform.right * moveSpeed * Time.deltaTime;
            anim.SetInteger("AnimationState", 1);
        }
        else if (target.position.x - 0.05f > myTransform.position.x)
        {
            myTransform.position += myTransform.right * moveSpeed * Time.deltaTime; 
            anim.SetInteger("AnimationState", 2);
        }


    }

}
