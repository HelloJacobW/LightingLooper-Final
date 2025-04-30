using Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatoScript : MonoBehaviour
{
    private PlayerSpeed speed;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        speed = FindFirstObjectByType<PlayerSpeed>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        gameObject.transform.position = player.transform.position;
       if(IsPositive(speed.speed.x))
            if(InTheMiddle(speed.speed.x,speed.speed.y))
                if (IsPositive(speed.speed.y))
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 45);
                else
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, -45);
            else 
                if(XisGreater(speed.speed.x,speed.speed.y))
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                else
                    if(IsPositive(speed.speed.y))
                        gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                    else
                        gameObject.transform.rotation = Quaternion.Euler(0, 0, -90);
      else
            if(InTheMiddle(speed.speed.x,speed.speed.y))
                if(IsPositive(speed.speed.y))
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 135);
                else
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 225);
            else
                if(XisGreater(speed.speed.x,speed.speed.y))
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
                else
                    if(IsPositive(speed.speed.y))
                        gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                    else
                        gameObject.transform.rotation = Quaternion.Euler(0, 0, -90);

    }
    private bool IsPositive(float x)
    {
        if (x < 0)
            return false;
        return true;
    }
    private bool InTheMiddle(float x, float y)
    {
        if(Mathf.Abs(y) - Mathf.Abs(x)  < -0.05)
            return true;
        return false;
    }
    private bool XisGreater(float x, float y)
    {
        if (Mathf.Abs(x) - Mathf.Abs(y) > 0)
            return true;
        return false;
    }
}
