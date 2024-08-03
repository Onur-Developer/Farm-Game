using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelcode : MonoBehaviour
{
    public Text tx;
    Button btn;
    public int levelscore;
    private void Start()
    {
        tx.text = "Level " + PlayerPrefs.GetInt("Level");
        btn=GameObject.Find("Button").GetComponent<Button>();
        btn.onClick.AddListener(levelbutton);
    }
    void levelbutton()
    {
        if (PlayerPrefs.GetInt("Level") == 1)
        {
            SceneManager.LoadScene("SampleScene");
        }
        else if (PlayerPrefs.GetInt("Level") == 2)
        {
            SceneManager.LoadScene("level2");
        }
        else if (PlayerPrefs.GetInt("Level") == 3)
        {
            SceneManager.LoadScene("level3");
        }
    }
}
