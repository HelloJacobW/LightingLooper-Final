using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        PlayerSpeed playerSpeed;
        // Start is called before the first frame update
        void Start()
        {
            playerSpeed = GetComponent<PlayerSpeed>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Jump()
        {
            if (playerSpeed.isFalling)
            {

            }
        }

        public bool FastFall()
        {
            return true;
        }

        public void Attacks()
        {

        }

        public void Portal(Vector2 direction)
        {

        }
    }
}
