using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFacePlayer : MonoBehaviour
{
    private GameObject Player;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if(Player.transform.position.x > transform.position.x)
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        else
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
    }
}
