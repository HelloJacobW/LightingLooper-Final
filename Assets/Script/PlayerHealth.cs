using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;
    private Animator animator;
    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }
    public void Hit()
    {
        health--;
        animator.SetTrigger("Hit");
        animator.SetBool("Stay", true);
        GameFeel.AddCameraShake(0.5f);
        if(health <= 0)
        {
            Debug.Log("Player death");
            animator.SetTrigger("Die");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("HurtBox"))
        {
            Hit();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
