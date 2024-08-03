using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button2Kodlevel2 : MonoBehaviour
{
    public Sprite kulube, ah�r, kovan;
    public int buttonskor, button�mag;
    �nekScript �nek;
    KopekScript kopek;
    Ar�script ar�;
    ButtonKodlevel2 kd;
    GameObject hatapaneli;
    private void Start()
    {
        hatapaneli = GameObject.Find("hatapaneli");
        buttonskor = 3;
        button�mag = 1;
        �nek = GameObject.FindWithTag("�nek").GetComponent<�nekScript>();
        kopek = GameObject.FindWithTag("K�pek").GetComponent<KopekScript>();
        ar� = GameObject.FindWithTag("Ar�").GetComponent<Ar�script>();
        kd = GameObject.Find("Button").GetComponent<ButtonKodlevel2>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ar�"))
        {
            if (buttonskor == ar�.ar�skor)
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
        else if (other.gameObject.CompareTag("K�pek"))
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
        else if (other.gameObject.CompareTag("�nek"))
        {
            if (buttonskor == �nek.inekskor)
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
    public void button�m()
    {
        if (button�mag == 1)
        {
            buttonskor = 1;
            this.gameObject.GetComponent<Image>().sprite = kulube;
            button�mag = 2;
        }
        else if (button�mag == 2)
        {
            buttonskor = 2;
            this.gameObject.GetComponent<Image>().sprite = ah�r;
            button�mag = 3;
        }
        else if (button�mag == 3)
        {
            buttonskor = 3;
            this.gameObject.GetComponent<Image>().sprite = kovan;
            button�mag = 1;
        }
    }
}
