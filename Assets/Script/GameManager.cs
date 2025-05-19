using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int number = 1;
    public bool lvl2 = false;
    public bool lvl3 = false;
    public bool lvl4 = false;
    public bool lvl5 = false;
    private void Awake()
    {
        if (instance)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public void Restart()
    {
        switch (number)
        {
            case 0:
                SceneManager.LoadScene(4);
                break;
            case 1:
                SceneManager.LoadScene(5);
                break;
            case 2:
                SceneManager.LoadScene(6);
                break;
            case 3:
                SceneManager.LoadScene(7);
                break;
            case 4:
                SceneManager.LoadScene(8);
                break;
            case 5:
                SceneManager.LoadScene(9);
                break;
            default:
                SceneManager.LoadScene(0);
                break;
        }
    }
    public void Tutorial()
    {
        SceneManager.LoadScene(4);
    }
    public void StartGame()
    {
        Debug.Log("Start");
        SceneManager.LoadScene(2);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Die()
    {
        SceneManager.LoadScene(3);
    }
    public void EnterLevel(int level)
    {
        level += 4;
        SceneManager.LoadScene(level);
    }
    public void NextLevel(int level)
    {
        if (level == 0)
        {
            SceneManager.LoadScene(2);
            return;
        }
        if (level == 1 && number > 1)
        {
            SceneManager.LoadScene(2);
            return;
        }
        if (level == 2 && number > 2)
        {
            SceneManager.LoadScene(2);
            return;
        }
        if (level == 3 && number > 3)
        {
            SceneManager.LoadScene(2);
            return;
        }
        if (level == 4 && number > 4)
        {
            SceneManager.LoadScene(2);
            return;
        }
        if (level == 5 && number > 5)
        {
            SceneManager.LoadScene(10);
            return;
        }
        number++;
        switch (number)
        {
            case 2:
                Debug.Log("#worked");
                lvl2 = true;
                SceneManager.LoadScene(2);
                break;
            case 3:
                lvl3 = true;
                SceneManager.LoadScene(2);
                break;
            case 4:
                lvl4 = true;
                SceneManager.LoadScene(2);
                break;
            case 5:
                lvl5 = true;
                SceneManager.LoadScene(2);
                break;
            case 6:
                SceneManager.LoadScene(10);
                break;
            default:
                Debug.Log("Broken math");
                break;
        }
    }
}