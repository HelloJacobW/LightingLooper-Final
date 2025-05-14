using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class EnemyHealth : MonoBehaviour
{
    private Animator an;
    private ForceField Orb;
    private void Start()
    {
        an = GetComponent<Animator>();
        Orb = FindFirstObjectByType<ForceField>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HitBox"))
        {
            Debug.Log("DIE");
            an.SetTrigger("Die");
            //Tell forceField to be less
            Orb.EnemyDeath();
        }
    }
    public void Break()
    {
        Debug.Log("Destroy");
        Destroy(gameObject);
    }
}
