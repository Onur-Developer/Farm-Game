using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KopekScript : MonoBehaviour
{
    public GameObject canvas;
    GameObject �mage;
    public int kopekskor = 1;
    void Start()
    {
        �mage = this.gameObject;
        �mage.transform.SetParent(canvas.gameObject.transform);
        if (PlayerPrefs.GetInt("Level") == 3)
        {
            �mage.transform.localScale = new Vector3(0.5f,0.5f,0.5f);
        }
        else
        {
            �mage.transform.localScale = Vector3.one;
        }
    }
}
