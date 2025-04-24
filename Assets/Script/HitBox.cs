using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour
{
    public GameObject Player;
    public PlayerSpeed speed;
    private void Awake()
    {
        speed = FindFirstObjectByType<PlayerSpeed>();
        gameObject.SetActive(false);
    }
    private void OnEnable()
    {
        transform.position = new Vector3(Player.transform.position.x + (Mathf.Abs(speed.speed.x) /speed.speed.x) * 2, Player.transform.position.y, Player.transform.position.z);
        Invoke("Disable", 1f);
    }
    private void Disable()
    {
        gameObject.SetActive(false);
    }
}
