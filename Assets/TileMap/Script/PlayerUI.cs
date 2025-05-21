using Player;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Image[] heartImages;
    public Image[] offHeartImages;
    private int health = 0;
    public PlayerSpeed speed;
    public Image[] manaImages;
    public Image[] manaOffImages;
    private int mana = 0;

    void Awake()
    {
        playerHealth = FindFirstObjectByType<PlayerHealth>();
        speed = FindFirstObjectByType<PlayerSpeed>();
    }

    void Update()
    {
        if (!playerHealth || !speed) return;
        if (health != playerHealth.health) UpdateHealth();
        if (mana != speed.airPortals) UpdateMana();
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
    void UpdateMana()
    {
        mana = speed.airPortals;

        for (int i = 0; i < manaImages.Length; i++)
        {
            if (i < mana)
            {
                manaImages[i].enabled = true;
                manaOffImages[i].enabled = false;
            }
            else
            {
                manaImages[i].enabled = false;
                manaOffImages[i].enabled = true;
            }
        }
    }
}
