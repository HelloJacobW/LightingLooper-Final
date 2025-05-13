using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.Animations;

public class MeleeEnemy : MonoBehaviour
{
    public GameObject shield;
    public GameObject hitBox;
    Animator an;
    int control = 0;
    private void Start()
    {
        ShieldOff();
        AttackOff();
        Invoke("AttackLoop", 2f);
        an = GetComponent<Animator>();
    }
    public void AttackLoop()
    {
        control++;
        switch (control)
        {
            case 1:
                ShieldOn();
                an.SetTrigger("Shield");
                Invoke("AttackLoop", 2f);
                break;
            case 2:
                ShieldOff();
                an.SetTrigger("Attack");
                Invoke("AttackLoop", 0.2f);
                break;
            case 3:
                AttackOn();
                Invoke("AttackLoop", 0.1f);
                break;
            case 4:
                AttackOff();
                control = 0;
                Invoke("AttackLoop", 3f);
                break;
            default:
                control = 0;
                Invoke("AttackLoop", 2f);
                break;
        }
    }
    public void ShieldOn()
    {
        shield.SetActive(true);
    }
    public void ShieldOff()
    {
        shield.SetActive(false);
    }
    public void AttackOn()
    {
        hitBox.SetActive(true);
    }
    public void AttackOff()
    {
        hitBox.SetActive(false);
    }
}
