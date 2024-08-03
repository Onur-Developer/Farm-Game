using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ekran1script : MonoBehaviour
{
    public GameObject creditspanel, nasýloynanýrpanel;
    void Start()
    {
        creditspanel.SetActive(false);
        nasýloynanýrpanel.SetActive(false);
    }
    public void basla()
    {
        PlayerPrefs.SetInt("Level", 1);
        SceneManager.LoadScene("ekran2");
    }
    public void creditsbuttonclýck()
    {
        creditspanel.SetActive(true);
    }
    public void creditspanelclosebutton()
    {
        creditspanel.SetActive(false);
    }
    public void nasýloynanýrbutton()
    {
        nasýloynanýrpanel.SetActive(true);
    }
    public void nasýloynanýrclosebutton()
    {
        nasýloynanýrpanel.SetActive(false);
    }
}
