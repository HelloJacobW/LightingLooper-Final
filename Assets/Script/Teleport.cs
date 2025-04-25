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
            if (collision.gameObject.CompareTag("Portal1")&&gameObject.CompareTag("Player"))
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
                momentum = "";
            }
        }
        //Portal Change Momentums Names Direction going, to direction going to
        public void GroundPortalDown()
        {
            print("Portal Down");
            speed.speed.x *= 0;
            speed.speed.y = -0.002f;
        }
        public void GroundPortalUp()
        {
            if (speed.MovingRight())
            {
                temp = speed.speed;
                speed.speed.y = temp.x;
                speed.speed.x = temp.x / 2;
            }
            else
            {
                temp = speed.speed;
                speed.speed.y = -1 * speed.speed.x;
                speed.speed.x = temp.x / 2;
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
                speed.speed.x =  Mathf.Abs(temp.y);
            }
            else
            {
                speed.speed.y = temp.x;
                speed.speed.x = -1 * Mathf.Abs(temp.y);
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
            speed.speed.y = (speed.fallMomentum + -1 * temp.y) / 2;
        }
        public void AerialUpPortalForward()
        {
            temp = speed.speed;
            if (speed.MovingRight())
            {
                speed.speed.x = temp.y;
                speed.speed.y = temp.x/2;
            }
            else
            {
                speed.speed.x = -1 * temp.y;
                speed.speed.y = -1 * temp.x/2;
            }
        }
        public void AerialDownPortalForward()
        {
            temp = speed.speed;
            if (speed.MovingRight())
            {
                speed.speed.x = (speed.fallMomentum + -1 * temp.y) / 2;
                speed.speed.y = temp.x;
            }
            else
            {
                speed.speed.x = temp.y;
                speed.speed.y = -1 * (speed.fallMomentum + -1 * temp.y) / 2;
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
                speed.speed.y = -1 * temp.x / 3;
            }
            else
            {
                speed.speed.x = temp.y;
                speed.speed.y = temp.x / 3;
            }
        }
        public void AerialDownPortalBack()
        {
            temp = speed.speed;
            if (speed.MovingRight())
            {
                speed.speed.x = -1 * (speed.fallMomentum + -1 * temp.y)/2;
                speed.speed.y = temp.x;
            }
            else
            {
                speed.speed.x = (speed.fallMomentum + -1 * temp.y)/2;
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
        public void DestroyPortals()
        {
            foreach (Portal portal2 in portal)
            {
                portal2.KillPortal();
            }
        }
    }
}
