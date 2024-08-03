using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ekran2script : MonoBehaviour
{
    public Slider slider;
    public float zaman;
    public Text tx;
    Color color;
    private void Awake()
    {
        Time.timeScale = 1f;
    }
    private void Start()
    {
        color = Color.red;
        zaman = 15f;
    }
    private void Update()
    {
        tx.text = slider.value.ToString();
        zaman -= Time.deltaTime;
        slider.value = zaman;
        if (zaman <= 5)
        {
            tx.color = Color.red;
            slider.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = color;
        }
        if (slider.value <= 0)
        {
            SceneManager.LoadScene("ekran3");
        }
    }
}
