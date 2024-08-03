using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kod : MonoBehaviour
{
    public Image ýmage;
    public Sprite dog;
    public Sprite cow;
    public Sprite bee;
    public Sprite ahýr;
    public Sprite kovan;
    public Sprite kulube;
    public int animalýmage,buttonýmag,buttonskor;
    private void Start()
    {
        buttonskor = 3;
        buttonýmag = 1;
        animalýmage = 3;
    }

    private void OnTriggerExit(Collider other)
    {
        var p = GameObject.FindGameObjectWithTag("GameController").GetComponent<RectTransform>();
        var pos = p.position;
        if (other.gameObject.CompareTag("GameController"))
        {
            p.position = new Vector3(pos.x, 1200f, pos.z);
            animalýmage = Random.Range(1, 4);
            if (animalýmage == 1)
            {
                ýmage.GetComponent<Image>().sprite = dog;
              
            }
            else if (animalýmage == 2)
            {
                ýmage.GetComponent<Image>().sprite = cow;
                
            }
            else if(animalýmage == 3)
            {
                ýmage.GetComponent<Image>().sprite = bee;
            }
        }
    }
    public void buttoným()
    {
        if(buttonýmag == 1)
        {
            buttonskor = 1;
            this.gameObject.GetComponent<Image>().sprite = kulube;
            buttonýmag = 2;
        }
        else if (buttonýmag == 2)
        {
            buttonskor = 2;
            this.gameObject.GetComponent<Image>().sprite = ahýr;
            buttonýmag =3;
        }
        else if(buttonýmag==3)
        {
            buttonskor = 3;
            this.gameObject.GetComponent<Image>().sprite = kovan;
            buttonýmag = 1;
        }
    }
}