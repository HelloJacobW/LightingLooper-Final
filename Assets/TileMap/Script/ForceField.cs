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
    public float div;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        orb = GameObject.FindGameObjectWithTag("Orb");
        speed = FindFirstObjectByType<PlayerSpeed>();
        push = false;
    }
    private void Update()
    {
        if(push)
            switch (Direction())
            {
                case "RightUp":
                    speed.speed.x -= knockBack * Time.deltaTime;
                    speed.speed.y += knockBack * Time.deltaTime;
                    break;
                case "LeftUp":
                    speed.speed.x += knockBack * Time.deltaTime;
                    speed.speed.y += knockBack * Time.deltaTime;
                    break;
                case "Right":
                    speed.speed.x -= knockBack * Time.deltaTime;
                    break;
                case "Left":
                    speed.speed.x += knockBack * Time.deltaTime;
                    break;
                default:
                    break;
            }
    }
    private string Direction()
    {
        Vector2 PlayPos = player.transform.position;
        if (orb == null)
            return "Nothing";
        Vector2 OrbPos = orb.transform.position;
        if (speed.isFalling)
        {
            if (PlayPos.y > OrbPos.y)
                if (PlayPos.x > OrbPos.x)
                    return "LeftUp";
                else
                    return "RightUp";
            else
                if (PlayPos.x > OrbPos.x)
                return "Left";
            else
                return "Right";
        
        }
        else
            if (PlayPos.x > OrbPos.x)
            return "Left";
        else
            return "Right";
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Entered");
            push = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Exited");
            push = false;
        }
    }
    public void EnemyDeath()
    {
        knockBack /= div;
    }
}
