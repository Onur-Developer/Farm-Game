using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausescript : MonoBehaviour
{
   public GameObject panel;
    private void Start()
    {
        panel.SetActive(false);

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
    public void quýt()
    {
        Application.Quit();
    }
}
