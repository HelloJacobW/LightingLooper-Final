using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerSpeed : MonoBehaviour
    {
        PlayerInput input;
        public Vector2 speed;
        [SerializeField]private float speedGain = 0.5f;
        [SerializeField] private float loseSpeed = 1f;
        public bool isFalling = false;
        private float lastMoveDirection;

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
            if (speed.x > 0) speed.x -= 0.01f * Time.deltaTime;
            else if (speed.x < 0) speed.x += 0.01f * Time.deltaTime;
                speed.x += 0.01f * input.GetMove() * Time.deltaTime;
        }

        private void Update()
        {
            if (isFalling)
            {
                speed.y -= 0.01f * Time.deltaTime;
            }
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Ground"))
            {
                speed.y = 0;
                isFalling = false;
            }
            if (other.gameObject.CompareTag("Wall"))
            {
                speed.x = 0;
            }
        }
    }
}
