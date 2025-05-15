using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbDeath : MonoBehaviour
{
    GameManager gameManager;
    public GameObject DeathEffect;
    public int level;
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HitBox"))
        {
            Instantiate(DeathEffect);
            gameManager.NextLevel(level);
            Destroy(gameObject);
        }
    }
}
