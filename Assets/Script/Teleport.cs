using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Player
{

    public class Teleport : MonoBehaviour
    {
        public GameObject SecondPortal;
        public Portal[] portal;
        private PlayerSpeed speed;
        private string momentum;
        private Vector2 temp;

        private void Start()
        {
            portal = FindObjectsOfType<Portal>();
            speed = GetComponent<PlayerSpeed>();
            temp = Vector2.zero;
        }
        public void SetMomentum(string momentums)
        {
            momentum = momentums;
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Portal1"))
            {
                gameObject.transform.position = SecondPortal.transform.position;
                switch (momentum)
                {
                    case "GroundBack":
                        GroundPortalBack();
                        break;
                    case "GroundDown":
                        GroundPortalDown();
                        break;
                    case "GroundUp":
                        GroundPortalUp();
                        break;
                    case "AirForwardDown":
                        AerialForwardPortalDown();
                        break;
                    case "AirUpDown":
                        AerialUpPortalDown();
                        break;
                    case "AirForwardBack":
                        AerialForwardPortalBack();
                        break;
                    case "AirForwardUp":
                        AerialForwardPortalUp();
                        break;
                    case "AirDownUp":
                        AerialDownPortalUp();
                        break;
                    case "AirUpForward":
                        AerialUpPortalForward();
                        break;
                    case "AirDownForward":
                        AerialDownPortalForward();
                        break;
                    case "AirDownBack":
                        AerialDownPortalBack();
                        break;
                    case "AirUpBack":
                        AerialUpPortalBack();
                        break;
                    default: break;
                }
                momentum = "Nada";
            }
        }
        //Portal Change Momentums Names Direction going, to direction going to
        public void GroundPortalDown()
        {
            if (speed.MovingRight())
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
            if (speed.MovingRight())
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
            if (speed.MovingRight())
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
            if (speed.MovingRight())
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
            if (speed.MovingRight())
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
            if (speed.MovingRight())
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
            if (speed.MovingRight())
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
            if (speed.MovingRight())
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

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Boundarie"))
            {
                gameObject.transform.position = Vector2.zero;
            }
        }
    }
}
