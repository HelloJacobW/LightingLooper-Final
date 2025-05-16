using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbDeath : MonoBehaviour
{
    GameManagerProxy gameManager;
    public GameObject DeathEffect;
    public int level;
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManagerProxy>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HitBox"))
        {
            Instantiate(DeathEffect, transform.position, Quaternion.identity);
            gameManager.CallNextLevel(level);
            Destroy(gameObject);
        }
    }
}
