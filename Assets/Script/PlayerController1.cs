using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        public GameObject Hitbox;
        PlayerSpeed playerSpeed;
        Portal[] portals;
        Teleport teleport;
        // Start is called before the first frame update
        void Start()
        {
            playerSpeed = GetComponent<PlayerSpeed>();
            teleport = GetComponent<Teleport>();
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

        public void Attacks()
        {
            Hitbox.SetActive(true);
        }

        public void PortalDirect(Vector2 direction)
        {
            string joystic;
            string firstPortalPlace;
            string goingRight;
            string grounded;
            if(playerSpeed.airPortals == 0)
            {
                return;
            }
            foreach (Portal portal2 in portals)
            {
                portal2.gameObject.SetActive(true);
            }
            if (playerSpeed.speed.x >= 0)
            {
                goingRight = "Ri";
            }
            else
            {
                goingRight = "Le";
            }
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
            if (!playerSpeed.isFalling)
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
                //print(firstPortalPlace + joystic + grounded);
                switch (firstPortalPlace + joystic + grounded)
                {
                    case "RightRightOnGround":
                    case "LeftLeftOnGround":
                        teleport.SetMomentum("ForwardForward");
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildGroundPortalForward();
                        }
                        break;
                    case "RightLeftOnGround":
                    case "LeftRightOnGround":
                        teleport.SetMomentum("GroundBack");
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildGroundPortalBack();
                        }
                        break;
                    case "RightUpOnGround":
                    case "LeftUpOnGround":
                        teleport.SetMomentum("GroundUp");
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildGroundPortalUp();
                        }
                        break;
                    case "RightDownOnGround":
                    case "LeftDownOnGround":
                        //Debug.Log("GroundPortal");
                        teleport.SetMomentum("GroundDown");
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildGroundPortalDown();
                        }
                        break;
                    default: break;
                }
            }
            else
            {
                playerSpeed.airPortals--;
                switch(firstPortalPlace + joystic)
                {
                    case "RightRight":
                    case "LeftLeft":
                        teleport.SetMomentum("AirForwardForward");
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildAerialForwardPortalForward();
                        }
                        break;
                    case "RightLeft":
                    case "LeftRight":
                        teleport.SetMomentum("AirForwardBack");
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildAerialForwardPortalBack();
                        }
                        break;
                    case "RightDown":
                    case "LeftDown":
                        teleport.SetMomentum("AirForwardDown");
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildAerialForwardPortalDown();
                        }
                        break;
                    case "RightUp":
                    case "LeftUp":
                        teleport.SetMomentum("AirForwardUp");
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildAerialForwardPortalUp();
                        }
                        break;
                    case "UpUp":
                        teleport.SetMomentum("AirUpUp");
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildAerialUpPortalUp();
                        }
                        break;
                    case "DownUp":
                        teleport.SetMomentum("AirDownUp");
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildAerialDownPortalUp();
                        }
                        break;
                    case "UpDown":
                        teleport.SetMomentum("AirUpDown");
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildAerialUpPortalDown();
                        }
                        break;
                    case "DownDown":
                        teleport.SetMomentum("AirDownDown");
                        foreach (Portal portal2 in portals)
                        {
                            portal2.BuildAerialDownPortalDown();
                        }
                        break;
                    default: break;
                }
            }
            switch(firstPortalPlace + joystic + goingRight)
            {
                case "DownRightRi":
                case "DownLeftLe":
                    teleport.SetMomentum("AirDownForward");
                    foreach (Portal portal2 in portals)
                    {
                        portal2.BuildAerialDownPortalForward();
                    }
                    break;
                case "DownRightLe":
                case "DownLeftRi":
                    teleport.SetMomentum("AirDownBack");
                    foreach (Portal portal2 in portals)
                    {
                        portal2.BuildAerialDownPortalBack();
                    }
                    break;
                case "UpRightRi":
                case "UpLeftLe":
                    teleport.SetMomentum("AirUpForward");
                    foreach (Portal portal2 in portals)
                    {
                        portal2.BuildAerialUpPortalForward();
                    }
                    break;
                case "UpRightLe":
                case "UpLeftRi":
                    teleport.SetMomentum("AirUpBack");
                    foreach (Portal portal2 in portals)
                    {
                        portal2.BuildAerialUpPortalBack();
                    }
                    break;
            }
        }
    }
}
