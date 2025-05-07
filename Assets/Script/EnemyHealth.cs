using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("In enemy");
        Debug.Log(collision.gameObject.name);
        Debug.Log(collision);
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("HitBox"))
        {
            //Tell forceField to be less
            Destroy(gameObject);
        }
    }
}
