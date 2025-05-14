using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int number;
    private void Awake()
    {
        if (instance)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void Tutorial()
    {
        SceneManager.LoadScene(4);
    }
    public void StartGame()
    {
        number = 1;
        SceneManager.LoadScene(1);
    }
    public void Die()
    {
        SceneManager.LoadScene(3);
    }
    public void NextLevel()
    {
        number++;
        if (number % 2 == 0)
            Invoke("NextLevel", 1f);
        else
            switch (number)
            {
                case 3:
                    Debug.Log("#worked");
                    break;
                case 5:
                    break;
                case 7:
                    break;
                default:
                    Debug.Log("Broken math");
                    break;
            }
    }
}