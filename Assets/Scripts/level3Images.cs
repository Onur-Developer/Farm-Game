using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3Images : MonoBehaviour
{
   private int rsayý,speed=5;
    GameObject ýmage;

    private void Awake()
    {
        rsayý = Random.Range(1, 5);

    }
    private void Start()
    {
        ýmage = this.gameObject;
    }
    private void FixedUpdate()
    {
        if (rsayý == 2)
        {
            ýmage.transform.position += Vector3.up*speed;
        }
        else if (rsayý == 3)
        {
            ýmage.transform.position += Vector3.left * speed;
        }
        else if(rsayý == 4)
        {
            ýmage.transform.position+=Vector3.right * speed;
        }
        else if (rsayý == 1)
        {
            ýmage.transform.position += Vector3.down * speed;
        }
    }
}
