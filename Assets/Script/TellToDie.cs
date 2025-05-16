using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TellToDie : MonoBehaviour
{
    GameManagerProxy gameManager;
    private void Start()
    {
        gameManager = FindFirstObjectByType<GameManagerProxy>();
    }
    public void TattleTell()
    {
        gameManager.CallDie();
    }
}
