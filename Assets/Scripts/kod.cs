using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kod : MonoBehaviour
{
    public Image �mage;
    public Sprite dog;
    public Sprite cow;
    public Sprite bee;
    public Sprite ah�r;
    public Sprite kovan;
    public Sprite kulube;
    public int animal�mage,button�mag,buttonskor;
    private void Start()
    {
        buttonskor = 3;
        button�mag = 1;
        animal�mage = 3;
    }

    private void OnTriggerExit(Collider other)
    {
        var p = GameObject.FindGameObjectWithTag("GameController").GetComponent<RectTransform>();
        var pos = p.position;
        if (other.gameObject.CompareTag("GameController"))
        {
            p.position = new Vector3(pos.x, 1200f, pos.z);
            animal�mage = Random.Range(1, 4);
            if (animal�mage == 1)
            {
                �mage.GetComponent<Image>().sprite = dog;
              
            }
            else if (animal�mage == 2)
            {
                �mage.GetComponent<Image>().sprite = cow;
                
            }
            else if(animal�mage == 3)
            {
                �mage.GetComponent<Image>().sprite = bee;
            }
        }
    }
    public void button�m()
    {
        if(button�mag == 1)
        {
            buttonskor = 1;
            this.gameObject.GetComponent<Image>().sprite = kulube;
            button�mag = 2;
        }
        else if (button�mag == 2)
        {
            buttonskor = 2;
            this.gameObject.GetComponent<Image>().sprite = ah�r;
            button�mag =3;
        }
        else if(button�mag==3)
        {
            buttonskor = 3;
            this.gameObject.GetComponent<Image>().sprite = kovan;
            button�mag = 1;
        }
    }
}