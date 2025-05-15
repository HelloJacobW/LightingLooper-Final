using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class RangedEnemyScript : MonoBehaviour
{
    private GameObject player;
    public GameObject bullet;
    public Transform bulletPos;
    private float timer = 0f;
    private Animator an;
    public int range;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        an = GetComponent<Animator>();
    }
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        if(distance < range)
        {
            timer += Time.deltaTime;
            if (timer > 2)
            {
                timer = 0;
                an.SetTrigger("Shoot");
                Invoke("Shoot", 0.5f);
            }
        }
    }
    public void Shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}
