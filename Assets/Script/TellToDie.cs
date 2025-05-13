using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TellToDie : MonoBehaviour
{
    GameManager gameManager;
    private void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }
    public void TattleTell()
    {
        gameManager.Die();
    }
}
