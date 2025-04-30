using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerSpeed : MonoBehaviour
    {
        PlayerInput input;
        public Vector2 speed;
        public float fallMomentum = 0;
        public bool[] rightStop = {false, false};
        public bool canPortal = true;
        public int airPortals = 5;
        [SerializeField] private float speedGain = 0.01f;
        [SerializeField] private float speedLoss = 0.1f;
        [SerializeField] private float fallSpeed = 0.1f;
        [SerializeField] private float maxXSpeed = 0.5f;
        [SerializeField] private float minXSpeed = -0.5f;
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
            speed.x = Mathf.Clamp(speed.x,minXSpeed, maxXSpeed);
                speed.x += speedGain * input.GetMove() * Time.deltaTime;
        }
        public void loseSpeed()
        {
            if (speed.x > 0) speed.x -= speedLoss * Time.deltaTime;
            else if (speed.x < 0) speed.x += speedLoss * Time.deltaTime;
        }

        public void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Ground"))
            {
                airPortals = 5;
                //Debug.Log("hitGround");
                speed.y = 0f;
                isFalling = false;
                fallMomentum = 0f;
            }
            if (other.gameObject.CompareTag("Wall"))
            {
                //Debug.Log("hit wall");
                rightStop[1] = true;
                canPortal = false;
                if (speed.x > 0) rightStop[0] = true;
                else rightStop[0] = false;
                speed.x = 0;
            }
        }
        public void OnCollisionExit2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Ground"))
            {
                //Debug.Log("offGround");
                isFalling = true;
                fallMomentum = 0f;
            }
            if (other.gameObject.CompareTag("Wall"))
            {
                //Debug.Log("off wall");
                rightStop[1] = false;
                canPortal = true;
            }
        }
        private void Update()
        {
            speed.y = Mathf.Clamp(speed.y,-1f,15f);
            if (isFalling) 
            {
                speed.y -= fallSpeed * Time.deltaTime;
                fallMomentum += Mathf.Abs(speed.y) * Time.deltaTime;
            }
            if(speed.y < 0f)
            {
                fallMomentum = 0;
            }
        }

        public bool MovingRight()
        {
            return speed.x >= 0;
        }
    }
}
