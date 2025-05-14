using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbDeath : MonoBehaviour
{
    GameManager gameManager;
    public GameObject DeathEffect;
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.transform.IsChildOf(transform) && collision.gameObject.CompareTag("HitBox"))
        {
            Instantiate(DeathEffect);
            gameManager.NextLevel();
            Destroy(gameObject);
        }
    }
}
