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

        private void Start()
        {
            portal = FindObjectsOfType<Portal>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Portal1"))
            {
                gameObject.transform.position = SecondPortal.transform.position;
                foreach (Portal portal2 in portal) 
                {
                    
                    //Debug.Log("Found GameObject" + portal2.gameObject.name);
                }
            }
        }
    }
}
