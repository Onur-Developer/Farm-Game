using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ekran1script : MonoBehaviour
{
    public GameObject creditspanel, nas�loynan�rpanel;
    void Start()
    {
        creditspanel.SetActive(false);
        nas�loynan�rpanel.SetActive(false);
    }
    public void basla()
    {
        PlayerPrefs.SetInt("Level", 1);
        SceneManager.LoadScene("ekran2");
    }
    public void creditsbuttoncl�ck()
    {
        creditspanel.SetActive(true);
    }
    public void creditspanelclosebutton()
    {
        creditspanel.SetActive(false);
    }
    public void nas�loynan�rbutton()
    {
        nas�loynan�rpanel.SetActive(true);
    }
    public void nas�loynan�rclosebutton()
    {
        nas�loynan�rpanel.SetActive(false);
    }
}
