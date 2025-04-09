using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerInput : MonoBehaviour
    {
        private APlayerControls inputActions;
        private PlayerSpeed speed;
        private PlayerController controller;
        [SerializeField] private float moveInput;
        

         void Awake()
        {
            speed = GetComponent<PlayerSpeed>();
            controller = GetComponent<PlayerController>();
            inputActions = new APlayerControls();        
        }
        void Start()
        {
            inputActions.PlayerActions.Move.started += OnMove;
            inputActions.PlayerActions.Move.performed += OnMove;
            inputActions.PlayerActions.Move.canceled += OnMove;

            inputActions.PlayerActions.Jump.started += ctx => controller.Jump();

            inputActions.PlayerActions.FastFall.started += ctx => controller.FastFall();

            inputActions.PlayerActions.Attack.canceled += ctx => controller.Attacks();

            inputActions.PlayerActions.Portal.started += ctx => controller.Portal(speed.speed);

            inputActions.Enable();
        }

        private void OnMove(UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
            moveInput = context.ReadValue<float>(); 
        }
        
        public float GetMove()
        {
            return moveInput;
        }
        // Update is called once per frame
        void Update()
        {
            speed.gainSpeed();
        }
    }
}
