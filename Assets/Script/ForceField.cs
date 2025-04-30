using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceField : MonoBehaviour
{
    private GameObject orb;
    private GameObject player;
    private PlayerSpeed speed;
    public bool push;
    public float knockBack;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        orb = GameObject.FindGameObjectWithTag("Orb");
        push = false;
        knockBack = 0.2f;
    }
    private void Update()
    {
        if(push)
            switch (Direction())
            {
                case "RightUp":
                    speed.speed.x += knockBack * Time.deltaTime;
                    speed.speed.y += knockBack * Time.deltaTime;
                    break;
                case "LeftUp":
                    speed.speed.x -= knockBack * Time.deltaTime;
                    speed.speed.y += knockBack * Time.deltaTime;
                    break;
                case "Right":
                    speed.speed.x += knockBack * Time.deltaTime;
                    break;
                case "Left":
                    speed.speed.x -= knockBack * Time.deltaTime;
                    break;
                default:
                    break;
            }
    }
    private string Direction()
    {
        return "direction";
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        push = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        push = false;
    }
}
