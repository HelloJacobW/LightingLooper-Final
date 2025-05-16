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
        timeOut = 0.3f;
    }
    private void OnEnable()
    {
        if(speed.speed.x > 0)
        {
            transform.position = new Vector3(Player.transform.position.x + 0.5f, Player.transform.position.y, Player.transform.position.z);
        }
        else
            transform.position = new Vector3(Player.transform.position.x + 0.5f, Player.transform.position.y, Player.gameObject.transform.position.z);
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
