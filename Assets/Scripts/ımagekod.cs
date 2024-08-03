using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ımagekod : MonoBehaviour
{
    public GameObject canvas;
    GameObject ımage;
    void Start()
    {
        ımage = this.gameObject;
        ımage.transform.SetParent(canvas.gameObject.transform);
        ımage.transform.localScale = Vector3.one;
    }

    void Update()
    {

    }
}
