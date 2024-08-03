using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KopekScript : MonoBehaviour
{
    public GameObject canvas;
    GameObject ýmage;
    public int kopekskor = 1;
    void Start()
    {
        ýmage = this.gameObject;
        ýmage.transform.SetParent(canvas.gameObject.transform);
        if (PlayerPrefs.GetInt("Level") == 3)
        {
            ýmage.transform.localScale = new Vector3(0.5f,0.5f,0.5f);
        }
        else
        {
            ýmage.transform.localScale = Vector3.one;
        }
    }
}
