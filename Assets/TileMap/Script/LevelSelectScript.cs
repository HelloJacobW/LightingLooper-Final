using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectScript : MonoBehaviour
{
    GameManager gameManager;
    public GameObject[] Levels;
    public GameObject[] Locked;
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();

        if (gameManager.lvl2)
        {
            Levels[0].SetActive(true);
            Locked[0].SetActive(false);
        }
        else
        {
            Levels[0].SetActive(false);
            Locked[0].SetActive(true);
        }
        if (gameManager.lvl3)
        {
            Levels[1].SetActive(true);
            Locked[1].SetActive(false);
        }
        else { Levels[1].SetActive(false);
            Locked[1].SetActive(true);}
        if (gameManager.lvl4)
        {
            Levels[2].SetActive(true);
            Locked[2].SetActive(false);
        }
        else
        {
            Levels[2].SetActive(false);
            Locked[2].SetActive(true);
        }
        if (gameManager.lvl5)
        {
            Levels[3].SetActive(true);
            Locked[3].SetActive(false);
        }
        else
        {
            Levels[3].SetActive(false);
            Locked[3].SetActive(true);
        }
    }
}
