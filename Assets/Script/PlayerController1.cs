using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        PlayerSpeed playerSpeed;
        Portal[] portals;
        // Start is called before the first frame update
        void Start()
        {
            playerSpeed = GetComponent<PlayerSpeed>();
            portals = FindObjectsOfType<Portal>();
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(playerSpeed.getSpeed(), Space.World);
        }

        public void StartFall()
        {
            playerSpeed.isFalling = true;
        }
        public void Jump()
        {
            if (!playerSpeed.isFalling)
                playerSpeed.speed.y = 12f * Time.deltaTime;
            playerSpeed.isFalling = true;
        }

        public bool FastFall()
        {
            return true;
        }

        public void Attacks()
        {

        }

        public void PortalDirect(Vector2 direction)
        {
            string joystic;
            string firstPortalPlace;
            string goingRight;
            string grounded;
            if(Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
            {
                if (direction.x > 0)
                {
                    joystic = "Right";
                }
                else
                {
                    joystic = "Left";
                }
            }
            else
            {
                if(direction.y > 0)
                {
                    joystic = "Up";
                }
                else
                {
                    joystic = "Down";
                }
            }
            if (playerSpeed.isFalling)
            {
                grounded = "OnGround";
            }
            else
            {
                grounded = "InAir";
            }
            if (Mathf.Abs(playerSpeed.speed.x) > Mathf.Abs(playerSpeed.speed.y))
            {
                if (playerSpeed.speed.x > 0)
                {
                    firstPortalPlace = "Right";
                }
                else
                {
                    firstPortalPlace = "Left";
                }
            }
            else
            {
                if (playerSpeed.speed.y > 0)
                {
                    firstPortalPlace = "Up";
                }
                else
                {
                    firstPortalPlace = "Down";
                }
            }
            if (grounded.Equals("OnGround"))
            {
                switch(firstPortalPlace + joystic + grounded)
                {
                    case "RightRightOnGround":
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildGroundPortalForward();
                        }
                        break;
                    case "LeftLeftOnGround":
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildGroundPortalForward();
                        }
                        break;
                    case "RightLeftOnGround":
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildGroundPortalBack();
                        }
                        break;
                    case "LeftRightOnGround":
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildGroundPortalBack();
                        }
                        break;
                    case "UpRightOnGround":
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildGroundPortalUp();
                        }
                        break;
                    case "UpLeftOnGround":
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildGroundPortalUp();
                        }
                        break;
                    case "DownRightOnGround":
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildGroundPortalDown();
                        }
                        break;
                    case "DownLeftOnGround":
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildGroundPortalDown();
                        }
                        break;
                }
            }
            else
            {
                switch(firstPortalPlace + joystic)
                {
                    case "RightRight":
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildAerialForwardPortalForward();
                        }
                        break;
                    case "LeftLeft":
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildAerialForwardPortalForward();
                        }
                        break;
                    case "DownRight":
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildAerialForwardPortalForward();
                        }
                        break;
                }
            }
        }
    }
}
