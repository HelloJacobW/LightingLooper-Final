using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TellToDie : MonoBehaviour
{
    GameManagerProxy gameManager;
    public void TattleTell()
    {
        gameManager = FindFirstObjectByType<GameManagerProxy>();
        gameManager.CallDie();
    }
}
