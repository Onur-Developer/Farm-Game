using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonKodlevel2 : MonoBehaviour
{
    public Text tx;
    public Sprite kulube, ah�r, kovan;
    Button hatabutonuevet, hatabutonuhay�r;
    public int buttonskor, button�mag;
    �nekScript �nek;
    KopekScript kopek;
    Ar�script ar�;
    public GameObject hatapaneli;
    public int score = 0;

    private void Awake()
    {
        Time.timeScale = 1f;
    }
    private void Start()
    {
        hatapaneli = GameObject.Find("hatapaneli");
        hatabutonuevet = GameObject.Find("hatabutonuevet").GetComponent<Button>();
        hatabutonuhay�r = GameObject.Find("hatabutonuhay�r").GetComponent<Button>();
        hatabutonuevet.onClick.AddListener(htevet);
        hatabutonuhay�r.onClick.AddListener(hthay�r);
        hatapaneli.SetActive(false);
        buttonskor = 3;
        button�mag = 1;
        �nek = GameObject.FindWithTag("�nek").GetComponent<�nekScript>();
        kopek = GameObject.FindWithTag("K�pek").GetComponent<KopekScript>();
        ar� = GameObject.FindWithTag("Ar�").GetComponent<Ar�script>();

    }
    private void Update()
    {
        switch (PlayerPrefs.GetInt("Level"))
        {
            case 2:
                tx.text = "Skorunuz: " + score.ToString() + "/20";
                if (score == 20)
                {
                    PlayerPrefs.SetInt("Level", 3);
                    SceneManager.LoadScene("ekran2");
                }
                break;
            case 3:
                tx.text = "Skorunuz: " + score.ToString() + "/30";
                if (score == 30)
                {
                    PlayerPrefs.SetInt("Level", 4);
                    SceneManager.LoadScene("gameoverscene");
                }
                break;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ar�"))
        {
            if (buttonskor == ar�.ar�skor)
            {
                Object.Destroy(other.gameObject);
                score++;
            }
            else
            {
                hatapaneli.SetActive(true);
                Time.timeScale = 0f;
            }
        }
        else if (other.gameObject.CompareTag("K�pek"))
        {
            if (buttonskor == kopek.kopekskor)
            {
                Object.Destroy(other.gameObject);
                score++;
            }
            else
            {
                hatapaneli.SetActive(true);
                Time.timeScale = 0f;
            }
        }
        else if (other.gameObject.CompareTag("�nek"))
        {
            if (buttonskor == �nek.inekskor)
            {
                Object.Destroy(other.gameObject);
                score++;
            }
            else
            {
                hatapaneli.SetActive(true);
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
    void htevet()
    {
        Time.timeScale = 1f;
        hatapaneli.SetActive(false);
    }
    void hthay�r()
    {
        SceneManager.LoadScene("gameoverscene");
    }
}
