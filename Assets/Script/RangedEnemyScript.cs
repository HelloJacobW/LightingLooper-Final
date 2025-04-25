using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemyScript : MonoBehaviour
{
    private GameObject player;
    public GameObject bullet;
    public Transform bulletPos;
    private float timer = 0f;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        if(distance < 10)
        {
            timer += Time.deltaTime;
            if(timer > 2)
            {
                timer = 0;
                Instantiate(bullet, bulletPos.position, Quaternion.identity);
            }
        }
    }
}
