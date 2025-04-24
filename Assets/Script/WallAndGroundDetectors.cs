using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallAndGroundDetectors : MonoBehaviour
{
    public PlayerSpeed speed;
    public bool wall;
    public bool ground;
    void Start()
    {
        speed = FindAnyObjectByType<PlayerSpeed>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            ground = true;
        }
        if (other.gameObject.CompareTag("Wall"))
        {
            wall = true;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            ground = false;
        }
        if (other.gameObject.CompareTag("Wall"))
        {
            wall = false;
        }
    }
    private void Update()
    {
        if (ground)
        {
            speed.speed.x = Mathf.Clamp(speed.speed.y,-0.005f,15f);
        }
        if (wall)
        {
            speed.speed.x = Mathf.Clamp(speed.speed.x, -0.01f, 0.01f);
        }
    }
}
