using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arıscript : MonoBehaviour
{
    public GameObject canvas;
    GameObject ımage;
    public int arıskor = 3;
    void Start()
    {
        ımage = this.gameObject;
        ımage.transform.SetParent(canvas.gameObject.transform);
        if (PlayerPrefs.GetInt("Level") == 3)
        {
            ımage.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
        else
        {
            ımage.transform.localScale = Vector3.one;
        }
    }
}
