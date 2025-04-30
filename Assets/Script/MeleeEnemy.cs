using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{
    public GameObject shield;
    public GameObject hitBox;

    public void ShieldOn()
    {
        shield.SetActive(true);
    }
    public void ShieldOff()
    {
        shield.SetActive(false);
    }
    public void Attack()
    {
        hitBox.SetActive(true);
    }
    public void AttackOff()
    {
        hitBox.SetActive(false);
    }
}
