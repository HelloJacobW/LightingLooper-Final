using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerSpeed : MonoBehaviour
    {
        public Vector2 speed;
        [SerializeField]private float speedGain = 1.2f;
        public bool isFalling = false;

        private void Start()
        {
            speed = Vector2.zero;
        }
        public Vector2 getSpeed()
        {
            return speed;
        }

        public void gainSpeed(bool right)
        {
            int rights;
            if (right) rights = 1;
            else rights = -1;

            speed.x += rights * speedGain;
        }

        private void Update()
        {
            
        }
    }
}
