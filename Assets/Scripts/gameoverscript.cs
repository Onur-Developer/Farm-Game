using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameoverscript : MonoBehaviour
{
    public Button bt;
    RawImage ým;
    public Texture win;
    public Text tx;
    private void Start()
    {
        ým=GameObject.Find("RawImage").GetComponent<RawImage>();
        if (PlayerPrefs.GetInt("Level") == 4)
        {
            tx.text = "Oyunu Kazandýnýz!";
            ým.texture = win;
            bt.interactable = false;
        }
    }
    public void anamenu()
    {
        SceneManager.LoadScene("ekran1");
    }
    public void playagain()
    {
        SceneManager.LoadScene("ekran3");
    }
    public void exitgame()
    {
        Application.Quit();
    }
}
