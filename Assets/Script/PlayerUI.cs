using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Image[] heartImages;
    public Image[] offHeartImages;
    private int health = 0;

    void Awake()
    {
        playerHealth = FindFirstObjectByType<PlayerHealth>();
    }

    void Update()
    {
        if (!playerHealth) return;
        if (health != playerHealth.health) UpdateHealth();
    }
    void UpdateHealth()
    {
        health = playerHealth.health;

        for(int i = 0; i < heartImages.Length; i++)
        {
            if(i < health)
            {
                heartImages[i].enabled = true;
                offHeartImages[i].enabled = false;
            }
            else
            {
                heartImages[i].enabled = false;
                offHeartImages[i].enabled = true;
            }
        }
    }
}
