using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class skor : MonoBehaviour
{
    public Text tx;
    public kod kod;
    public GameObject panel;
    int score;
    private void Start()
    {
        panel.SetActive(false);
        score = 0;
        kod = GameObject.FindGameObjectWithTag("Player").GetComponent<kod>();
    }
    private void FixedUpdate()
    {
        tx.text = "Skor: " + score.ToString() + "/10";
        PlayerPrefs.SetInt("Skor", score);
        if (score == 10)
        {
            PlayerPrefs.SetInt("Level", 2);
            SceneManager.LoadScene("ekran2");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (kod.animalýmage == kod.buttonskor)
            {
                score++;
            }
            else
            {
                SceneManager.LoadScene("gameoverscene");
            }
        }

    }
    public void pausebutton()
    {
        Time.timeScale = 0f;
        panel.SetActive(true);
    }
    public void returngame()
    {
        Time.timeScale = 1f;
        panel.SetActive(false);
    }
    public void anamenu()
    {
        SceneManager.LoadScene("ekran1");
    }
   public void exitt()
    {
        Application.Quit();
    }
}
