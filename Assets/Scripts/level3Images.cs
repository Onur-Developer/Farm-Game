using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3Images : MonoBehaviour
{
   private int rsay�,speed=5;
    GameObject �mage;

    private void Awake()
    {
        rsay� = Random.Range(1, 5);

    }
    private void Start()
    {
        �mage = this.gameObject;
    }
    private void FixedUpdate()
    {
        if (rsay� == 2)
        {
            �mage.transform.position += Vector3.up*speed;
        }
        else if (rsay� == 3)
        {
            �mage.transform.position += Vector3.left * speed;
        }
        else if(rsay� == 4)
        {
            �mage.transform.position+=Vector3.right * speed;
        }
        else if (rsay� == 1)
        {
            �mage.transform.position += Vector3.down * speed;
        }
    }
}
