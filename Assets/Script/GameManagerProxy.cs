using UnityEngine;

public class GameManagerProxy : MonoBehaviour
{
    public GameManager manager; // Drag the GameManager from the scene

    private void Awake()
    {
        // Optionally auto-find the GameManager in the scene
        if (manager == null)
        {
            manager = FindObjectOfType<GameManager>();
        }

        if (manager == null)
        {
            Debug.LogError("GameManagerProxy could not find GameManager in scene.");
        }
    }

    public void CallStartGame()
    {
        if (manager != null) manager.StartGame();
    }

    public void CallMainMenu()
    {
        Debug.Log("Call mainmenu");
        if (manager != null) manager.MainMenu();
    }

    public void CallRestart()
    {
        if (manager != null) manager.Restart();
    }

    public void CallTutorial()
    {
        if (manager != null) manager.Tutorial();
    }

    public void CallDie()
    {
        if (manager != null) manager.Die();
    }

    public void CallEnterLevel(int level)
    {
        if (manager != null) manager.EnterLevel(level);
    }

    public void CallNextLevel(int level)
    {
        Debug.Log("Work");
        if (manager != null) manager.NextLevel(level);
    }
}
