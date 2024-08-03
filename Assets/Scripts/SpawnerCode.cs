using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerCode : MonoBehaviour
{
    GameObject ar�, inek, k�pek;
    public float spawntime;
    public int randomsay�;
    void Start()
    {
        ar� = GameObject.FindWithTag("Ar�");
        inek = GameObject.FindWithTag("�nek");
        k�pek = GameObject.FindWithTag("K�pek");
        spawntime = 0f;
    }
    private void FixedUpdate()
    {
        if (spawntime == 0f)
        {
            randomsay� = Random.Range(1, 4);
            if (randomsay� == 1)
            {
                Instantiate(ar�, this.gameObject.transform.position, Quaternion.identity);
            }
            else if (randomsay� == 2)
            {
                Instantiate(inek, this.gameObject.transform.position, Quaternion.identity);
            }
            else if (randomsay� == 3)
            {
                Instantiate(k�pek, this.gameObject.transform.position, Quaternion.identity);
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
