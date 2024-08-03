using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button2Kodlevel2 : MonoBehaviour
{
    public Sprite kulube, ahýr, kovan;
    public int buttonskor, buttonýmag;
    ÝnekScript ýnek;
    KopekScript kopek;
    Arýscript arý;
    ButtonKodlevel2 kd;
    GameObject hatapaneli;
    private void Start()
    {
        hatapaneli = GameObject.Find("hatapaneli");
        buttonskor = 3;
        buttonýmag = 1;
        ýnek = GameObject.FindWithTag("Ýnek").GetComponent<ÝnekScript>();
        kopek = GameObject.FindWithTag("Köpek").GetComponent<KopekScript>();
        arý = GameObject.FindWithTag("Arý").GetComponent<Arýscript>();
        kd = GameObject.Find("Button").GetComponent<ButtonKodlevel2>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Arý"))
        {
            if (buttonskor == arý.arýskor)
            {
                Object.Destroy(other.gameObject);
                kd.score++;
            }
            else
            {
                kd.hatapaneli.SetActive(true);
                Time.timeScale = 0f;
            }
        }
        else if (other.gameObject.CompareTag("Köpek"))
        {
            if (buttonskor == kopek.kopekskor)
            {
                Object.Destroy(other.gameObject);
                kd.score++;
            }
            else
            {
                kd.hatapaneli.SetActive(true);
                Time.timeScale = 0f;
            }
        }
        else if (other.gameObject.CompareTag("Ýnek"))
        {
            if (buttonskor == ýnek.inekskor)
            {
                Object.Destroy(other.gameObject);
                kd.score++;
            }
            else
            {
                kd.hatapaneli.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }
    public void buttoným()
    {
        if (buttonýmag == 1)
        {
            buttonskor = 1;
            this.gameObject.GetComponent<Image>().sprite = kulube;
            buttonýmag = 2;
        }
        else if (buttonýmag == 2)
        {
            buttonskor = 2;
            this.gameObject.GetComponent<Image>().sprite = ahýr;
            buttonýmag = 3;
        }
        else if (buttonýmag == 3)
        {
            buttonskor = 3;
            this.gameObject.GetComponent<Image>().sprite = kovan;
            buttonýmag = 1;
        }
    }
}
