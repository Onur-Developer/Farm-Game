using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ekran1script : MonoBehaviour
{
    public GameObject creditspanel, nasıloynanırpanel;
    void Start()
    {
        creditspanel.SetActive(false);
        nasıloynanırpanel.SetActive(false);
    }
    public void basla()
    {
        PlayerPrefs.SetInt("Level", 1);
        SceneManager.LoadScene("ekran2");
    }
    public void creditsbuttonclıck()
    {
        creditspanel.SetActive(true);
    }
    public void creditspanelclosebutton()
    {
        creditspanel.SetActive(false);
    }
    public void nasıloynanırbutton()
    {
        nasıloynanırpanel.SetActive(true);
    }
    public void nasıloynanırclosebutton()
    {
        nasıloynanırpanel.SetActive(false);
    }
}
