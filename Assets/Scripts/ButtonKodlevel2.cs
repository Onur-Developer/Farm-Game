using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonKodlevel2 : MonoBehaviour
{
    public Text tx;
    public Sprite kulube, ahýr, kovan;
    Button hatabutonuevet, hatabutonuhayýr;
    public int buttonskor, buttonýmag;
    ÝnekScript ýnek;
    KopekScript kopek;
    Arýscript arý;
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
        hatabutonuhayýr = GameObject.Find("hatabutonuhayýr").GetComponent<Button>();
        hatabutonuevet.onClick.AddListener(htevet);
        hatabutonuhayýr.onClick.AddListener(hthayýr);
        hatapaneli.SetActive(false);
        buttonskor = 3;
        buttonýmag = 1;
        ýnek = GameObject.FindWithTag("Ýnek").GetComponent<ÝnekScript>();
        kopek = GameObject.FindWithTag("Köpek").GetComponent<KopekScript>();
        arý = GameObject.FindWithTag("Arý").GetComponent<Arýscript>();

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
        if (other.gameObject.CompareTag("Arý"))
        {
            if (buttonskor == arý.arýskor)
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
        else if (other.gameObject.CompareTag("Köpek"))
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
        else if (other.gameObject.CompareTag("Ýnek"))
        {
            if (buttonskor == ýnek.inekskor)
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
    void htevet()
    {
        Time.timeScale = 1f;
        hatapaneli.SetActive(false);
    }
    void hthayýr()
    {
        SceneManager.LoadScene("gameoverscene");
    }
}
