using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Tilemaps;

namespace Player
{
    public class Portal : MonoBehaviour
    {
        private PlayerSpeed speed;
        public Vector2 playPos;
        private bool firstPortal;
        private float gp = 0.75f;
        private PortalChecker check;
        public GameObject PlayerGameObject;
        public Event PortalAppear = new Event();
        public Teleport tele;
        public GameObject floor;
        public TilemapCollider2D floorCollider;
        public CircleCollider2D portalCollider;
        void Start()
        {
            check = GetComponent<PortalChecker>();
            speed = FindFirstObjectByType<PlayerSpeed>();
            if(gameObject.CompareTag("Portal1")) firstPortal = true;
            tele = FindFirstObjectByType<Teleport>();
            floorCollider = floor.GetComponent<TilemapCollider2D>();
            portalCollider = gameObject.GetComponent<CircleCollider2D>();
        }

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
            check.CheckPortal(gameObject.transform.position);
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
            check.CheckPortal(gameObject.transform.position);
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
            check.CheckPortal(gameObject.transform.position);
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
            check.CheckPortal(gameObject.transform.position);
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
            check.CheckPortal(gameObject.transform.position);
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
            check.CheckPortal(gameObject.transform.position);
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
            check.CheckPortal(gameObject.transform.position);
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
            check.CheckPortal(gameObject.transform.position);
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
            check.CheckPortal(gameObject.transform.position);
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
            check.CheckPortal(gameObject.transform.position);
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
            check.CheckPortal(gameObject.transform.position);
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
            check.CheckPortal(gameObject.transform.position);
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
            check.CheckPortal(gameObject.transform.position);
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
            check.CheckPortal(gameObject.transform.position);
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
            check.CheckPortal(gameObject.transform.position);
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
            check.CheckPortal(gameObject.transform.position);
        }
        //Kill portal if in wall
        private void OnEnable()
        {
            playPos = new Vector2(PlayerGameObject.transform.position.x, PlayerGameObject.transform.position.y);
        }
        private void Update()
        {
            playPos = new Vector2(PlayerGameObject.transform.position.x,PlayerGameObject.transform.position.y);
         //   if(floor != null && floorCollider.bounds.Intersects(portalCollider.bounds))
          //  {
          //      tele.DestroyPortals();
          //  }
        }
        public void KillPortal()
        {
            gameObject.SetActive(false);
        }
    }
}
