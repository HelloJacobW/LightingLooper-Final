using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private PlayerSpeed speed;
    void Start()
    {
        speed = GetComponent<PlayerSpeed>();
    }
    void Update()
    {
        
    }
}
