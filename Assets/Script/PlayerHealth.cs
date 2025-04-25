using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;
    public float timer = 0;
    public void Hit()
    {
        health--;
        GameFeel.AddCameraShake(0.5f);
        if(health < 0)
        {
            timer += Time.deltaTime;
            if(timer > 2)
            health = 3;
        }
    }
}
