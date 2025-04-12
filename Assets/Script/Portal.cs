using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace Player
{
    public class Portal : MonoBehaviour
    {
        private PlayerSpeed speed;
        private Vector2 temp;
        private Vector2 playPos;
        private bool firstPortal;
        private float gp = 0.75f;
        public GameObject PlayerGameObject;
        [SerializeField] private Event PortalApear;
        void Start()
        {
            speed = FindFirstObjectByType<PlayerSpeed>();
            temp = Vector2.zero;
            if(gameObject.CompareTag("Portal1")) firstPortal = true;
        }
        private void Update()
        {
            BuildAerialUpPortalUp();
            playPos = new Vector2(PlayerGameObject.transform.position.x,PlayerGameObject.transform.position.y);
        }

        //Portal Change Momentums Names Direction going, to direction going to
        public void GroundPortalDown()
        {
            if(speed.MovingRight())
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
            if(speed.MovingRight())
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
            if(speed.MovingRight())
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

        //Portals Placement  names direction going, to direction going to

        public void BuildGroundPortalForward()
        {
            if (firstPortal)
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + 2, playPos.y + gp, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x - 2, playPos.y + gp, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
            else
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x - 2, playPos.y + gp, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x + 2, playPos.y + gp, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
        }

        public void BuildGroundPortalDown()
        {
            if (firstPortal)
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + 2, playPos.y + gp, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x - 2, playPos.y + gp, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
            else
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x, playPos.y + 2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x, playPos.y + 2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
            }
        }

        public void BuildGroundPortalUp()
        {
            if (firstPortal)
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + 2, playPos.y + gp, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x - 2, playPos.y + gp, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
            else
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x, playPos.y + 2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x, playPos.y + 2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
            }
        }

        public void BuildGroundPortalBack()
        {
            if (firstPortal)
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + 2, playPos.y + gp, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x - 2, playPos.y + gp, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
            else
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + 2, playPos.y + gp + 3, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x - 2, playPos.y + gp + 3, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
        }
        public void BuildAerialForwardPortalForward()
        {
            if (firstPortal)
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + 1, playPos.y + speed.speed.y, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x - 1, playPos.y + speed.speed.y, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
            else
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + 1, playPos.y + speed.speed.y + 3, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x - 1, playPos.y + speed.speed.y + 3, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
        }

        public void BuildAerialDownPortalForward()
        {
            if (firstPortal)
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + speed.speed.x, playPos.y - 1.5f, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x + speed.speed.x, playPos.y - 1.5f, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
            }
            else
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + gp*2, playPos.y, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x - 1.5f, playPos.y, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
        }

        public void BuildAerialUpPortalForward()
        {
            if (firstPortal)
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x, playPos.y + gp*2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0,90);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x, playPos.y + gp*2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
            }
            else
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + gp*2, playPos.y, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x - gp*2, playPos.y, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
        }
        public void BuildAerialForwardPortalDown()
        {
            if (firstPortal)
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + 1, playPos.y + speed.speed.y, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x - 1, playPos.y + speed.speed.y, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
            else
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x - speed.speed.x, playPos.y - 2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x - speed.speed.x, playPos.y - 2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
            }
        }
        public void BuildAerialDownPortalDown()
        {
            if (firstPortal)
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + speed.speed.x, playPos.y - gp*2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x + speed.speed.x, playPos.y - gp*2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
            }
            else
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x - speed.speed.x - 2.5f, playPos.y - gp*2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x - speed.speed.x + 2.5f, playPos.y - gp*2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
            }
        }
        public void BuildAerialUpPortalDown()
        {
            if (firstPortal)
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + speed.speed.x, playPos.y + gp*2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x + speed.speed.x, playPos.y + gp*2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
            }
            else
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + speed.speed.x, playPos.y - 1.75f, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x + speed.speed.x, playPos.y - 1.75f, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
            }
        }
        public void BuildAerialForwardPortalBack()
        {
            if (firstPortal)
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + 1, playPos.y + speed.speed.y, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x - 1, playPos.y + speed.speed.y, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
            else
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + 1, playPos.y + speed.speed.y + 3, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x - 1, playPos.y + speed.speed.y + 3, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
        }
        public void BuildAerialDownPortalBack()
        {
            if (firstPortal)
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + speed.speed.x, playPos.y - 1.75f, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x + speed.speed.x, playPos.y - 1.75f, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
            }
            else
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x - gp*2, playPos.y + speed.speed.y, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x + gp*2, playPos.y + speed.speed.y, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
        }
        public void BuildAerialUpPortalBack()
        {
            if (firstPortal)
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + speed.speed.x, playPos.y + gp*2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x + speed.speed.x, playPos.y + gp*2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
            }
            else
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x - gp * 2, playPos.y + speed.speed.y, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x + gp * 2, playPos.y + speed.speed.y, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
        }
        public void BuildAerialForwardPortalUp()
        {
            if (firstPortal)
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + 2, playPos.y + speed.speed.y, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x - 2, playPos.y + speed.speed.y, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
            else
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + speed.speed.x, playPos.y - speed.speed.y + 2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x + speed.speed.x, playPos.y - speed.speed.y + 2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
            }
        }
        public void BuildAerialDownPortalUp()
        {
            if (firstPortal)
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + speed.speed.x, playPos.y - 1.75f, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x + speed.speed.x, playPos.y - 1.75f, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
            }
            else
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + speed.speed.x, playPos.y + gp * 2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x + speed.speed.x, playPos.y + gp * 2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
            }
        }
        public void BuildAerialUpPortalUp()
        {
            if (firstPortal)
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x + speed.speed.x, playPos.y + gp * 2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x + speed.speed.x, playPos.y + gp * 2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
            }
            else
            {
                if (speed.MovingRight())
                {
                    gameObject.transform.position = new Vector3(playPos.x - 3, playPos.y + gp * 2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                else
                {
                    gameObject.transform.position = new Vector3(playPos.x + 3, playPos.y + gp * 2, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
            }
        }
    }
}
