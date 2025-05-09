using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour
{
    public GameObject Player;
    public PlayerSpeed speed;
    public float timeOut;
    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        speed = FindFirstObjectByType<PlayerSpeed>();
        gameObject.SetActive(false);
    }
    private void OnEnable()
    {
        if (gameObject && speed.speed.x != 0)
            transform.position = new Vector3(Player.transform.position.x + (Mathf.Abs(speed.speed.x) / speed.speed.x), Player.transform.position.y, Player.transform.position.z);
        else
            transform.position = new Vector3(Player.transform.position.x + 2, Player.transform.position.y, Player.transform.position.z);
        Invoke("Disable", timeOut);
    }
    private void Update()
    {
        if(gameObject && speed.speed.x != 0)
        transform.position = new Vector3(Player.transform.position.x + (Mathf.Abs(speed.speed.x) / speed.speed.x) * 2, Player.transform.position.y, Player.transform.position.z);
    }
    private void Disable()
    {
        gameObject.SetActive(false);
    }
}
