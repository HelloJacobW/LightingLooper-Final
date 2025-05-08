using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;
    public float timer = 0;
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Hit()
    {
        health--;
        animator.SetTrigger("Hit");
        animator.SetInteger("Health", health);
        animator.SetBool("Stay", true);
        GameFeel.AddCameraShake(0.5f);
        if(health < 0)
        {
            timer += Time.deltaTime;
            if(timer > 2)
            health = 3;
        }
    }
}
