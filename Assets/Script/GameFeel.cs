using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFeel : MonoBehaviour
{
    public static GameFeel instance;
    public float cameraShakeTime = 0f;
    private void Awake()
    {
        if (instance)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public static void AddCameraShake(float time)
    {
        if (instance)
        {
            instance.cameraShakeTime = time;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (cameraShakeTime > 0f)
        {
            cameraShakeTime -= Time.deltaTime;
            Vector3 newCamerPosition = new Vector3();
            newCamerPosition.x = Random.Range(-0.1f, 0.1f);
            newCamerPosition.y = Random.Range(-0.1f, 0.1f);
            newCamerPosition.z = -10;
            Camera.main.transform.position = newCamerPosition;
        }
    }
}
