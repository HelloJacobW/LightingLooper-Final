using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerSpeed : MonoBehaviour
    {
        PlayerInput input;
        public Vector2 speed;
        [SerializeField]private float speedGain = 0.1f;
        [SerializeField] private float speedLoss = 0.1f;
        public bool isFalling = true;

        private void Start()
        {
            input = GetComponent<PlayerInput>();
            speed = Vector2.zero;
        }
        public Vector2 getSpeed()
        {
            return speed;
        }

        public void gainSpeed()
        {
                speed.x += speedGain * input.GetMove() * Time.deltaTime;
        }
        public void loseSpeed()
        {
            if (speed.x > 0) speed.x -= 0.01f * Time.deltaTime;
            else if (speed.x < 0) speed.x += 0.01f * Time.deltaTime;
        }

        public void OnCollisionEnter2D(Collision2D other)
        {
            print("anything");
            Debug.Log("hitsomething");
            if (other.gameObject.CompareTag("Ground"))
            {
                Debug.Log("hitGround");
                speed.y = 0f;
                isFalling = false;
            }
            if (other.gameObject.CompareTag("Wall"))
            {
                Debug.Log("hit wall");
                speed.x = 0;
            }
        }
        private void Update()
        {
            speed.y = Mathf.Clamp(speed.y,-1f,15f);
            if (isFalling) 
            {
                speed.y -= 0.01f * Time.deltaTime;
            }
        }
    }
}
