using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player
{
    public class Portal : MonoBehaviour
    {
        private PlayerSpeed speed;
        private Vector2 temp;
        void Start()
        {
            speed = GetComponent<PlayerSpeed>();
            temp = Vector2.zero;
        }

        //Portal Change Momentums
        public void GroundPortalDown()
        {
            if(speed.speed.x > 0)
            {
                temp = speed.speed;
                speed.speed.y = -1 * speed.speed.x;
            }
            else
            {
                temp = speed.speed;
                speed.speed.y = speed.speed.x;
            }
        }
        public void GroundPortalUp() 
        {
            if(speed.speed.x > 0)
            {
                temp = speed.speed;
                speed.speed.y = temp.x;
            }
            else
            {
                temp = speed.speed;
                speed.speed.y = -1 * speed.speed.x;
            }
        }
        public void GroundPortalBack()
        {
            speed.speed.x *= -1;
        }
        public void AerialForwardPortalDown()
        {
            temp = speed.speed;
            if(speed.speed.x > 0)
            {
                speed.speed.y = -1 * temp.x;
                speed.speed.x = -1 * temp.y;
            }
            else
            {
                speed.speed.y = temp.x;
                speed.speed.x = temp.y;
            }
        }
        public void AerialUpPortalDown()
        {
            speed.speed.y *= -1;
        }
        public void AerialForwardPortalUp()
        {
            temp = speed.speed;
            if (speed.speed.x > 0)
            {
                speed.speed.y = temp.x;
                speed.speed.x = -1 * temp.y;
            }
            else
            {
                speed.speed.y = -1 * temp.x;
                speed.speed.x = temp.y;
            }
        }
        public void AerialDownPortalUp()
        {
            speed.speed.y = speed.fallMomentum;
        }
        public void AerialUpPortalForward()
        {
            temp = speed.speed;
            if (speed.speed.x > 0)
            {
                speed.speed.x = temp.y;
                speed.speed.y = temp.x;
            }
            else
            {
                speed.speed.x = -1 * temp.y;
                speed.speed.y = -1 * temp.x;
            }
        }
        public void AerialDownPortalForward()
        {
            temp = speed.speed;
            if (speed.speed.x > 0)
            {
                speed.speed.x = speed.fallMomentum;
                speed.speed.y = temp.x;
            }
            else
            {
                speed.speed.x = -1 * speed.fallMomentum;
                speed.speed.y = -1 * temp.x;
            }
        }
        public void AerialForwardPortalBack()
        {
            speed.speed.x *= -1;
        }
        public void AerialUpPortalBack()
        {
            temp = speed.speed;
            if (speed.speed.x > 0)
            {
                speed.speed.x = -1 * temp.y;
                speed.speed.y = -1 * temp.x;
            }
            else
            {
                speed.speed.x = temp.y;
                speed.speed.y = temp.x;
            }
        }
        public void AerialDownPortalBack()
        {
            temp = speed.speed;
            if (speed.speed.x > 0)
            {
                speed.speed.x = -1 * speed.fallMomentum;
                speed.speed.y = temp.x;
            }
            else
            {
                speed.speed.x = speed.fallMomentum;
                speed.speed.y = -1 * temp.x;
            }
        }
         
        //The End of the Portal ReMomentems
    }
}
