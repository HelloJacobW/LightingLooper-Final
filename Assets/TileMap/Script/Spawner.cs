using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;
    public void SpawnEnemy() 
    {
        Instantiate(Enemy);
    }
}
