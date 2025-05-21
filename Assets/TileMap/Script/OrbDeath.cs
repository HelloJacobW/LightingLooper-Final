using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbDeath : MonoBehaviour
{
    GameManagerProxy gameManager;
    public GameObject DeathEffect;
    public int level;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HitBox"))
        {
            gameManager = FindFirstObjectByType<GameManagerProxy>();
            Instantiate(DeathEffect, transform.position, Quaternion.identity);
            gameManager.CallNextLevel(level);
            Destroy(gameObject);
        }
    }
}
