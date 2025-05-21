using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerAnimation : MonoBehaviour
{
    private PlayerSpeed speed;
    public Animator an;
    void Start()
    {
        speed = FindFirstObjectByType<PlayerSpeed>();
        an = GetComponentInChildren<Animator>();
    }
    void Update()
    {
        an.SetFloat("Speed", Mathf.Abs(speed.speed.x));
        if (an.GetBool("Stay"))
            Invoke("No", 6f);
        an.SetBool("Grounded", !speed.isFalling);
        if (speed.isFalling)
            if (speed.speed.y > 0f)
                an.SetBool("FallingDown", false);
            else
                an.SetBool("FallingDown", true);

    }
    void No()
    {
        an.SetBool("Stay", false);
    }
}
