using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerCode : MonoBehaviour
{
    GameObject arý, inek, köpek;
    public float spawntime;
    public int randomsayý;
    void Start()
    {
        arý = GameObject.FindWithTag("Arý");
        inek = GameObject.FindWithTag("Ýnek");
        köpek = GameObject.FindWithTag("Köpek");
        spawntime = 0f;
    }
    private void FixedUpdate()
    {
        if (spawntime == 0f)
        {
            randomsayý = Random.Range(1, 4);
            if (randomsayý == 1)
            {
                Instantiate(arý, this.gameObject.transform.position, Quaternion.identity);
            }
            else if (randomsayý == 2)
            {
                Instantiate(inek, this.gameObject.transform.position, Quaternion.identity);
            }
            else if (randomsayý == 3)
            {
                Instantiate(köpek, this.gameObject.transform.position, Quaternion.identity);
            }
        }
        spawntime += Time.deltaTime;
        switch (PlayerPrefs.GetInt("Level"))
        {
            case 1:
                if (spawntime >= 5)
                {
                    spawntime = 0f;
                }
                break;
            case 2:
                if (spawntime >= 5)
                {
                    spawntime = 0f;
                }
                break;
            case 3:
                if (spawntime >= 2)
                {
                    spawntime = 0f;
                }
                break;
        }
    }
}
