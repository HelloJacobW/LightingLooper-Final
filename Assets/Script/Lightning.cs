using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    private PlayerSpeed speed;
    public GameObject lightning;
    void Start()
    {
        speed = FindFirstObjectByType<PlayerSpeed>();
    }

    void Update()
    {
        if(Mathf.Abs(speed.speed.x) > 0.01 || Mathf.Abs(speed.speed.y) > 0.01)
        {
            lightning.SetActive(true);
        }
        else
        {
            lightning.SetActive(false);
        }
    }
}
