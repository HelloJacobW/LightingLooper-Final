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
        private PlayerAnimation animate;
        [SerializeField] private Vector2 stickDirection;
        [SerializeField] private float moveInput;
        private bool loseSpeed = false;
        

         void Awake()
        {
            speed = GetComponent<PlayerSpeed>();
            controller = GetComponent<PlayerController>();
            inputActions = new APlayerControls();
            animate = GetComponent<PlayerAnimation>();
            stickDirection = Vector2.zero;
        }
        void Start()
        {
            inputActions.PlayerActions.Move.started += OnMove;
            inputActions.PlayerActions.Move.performed += OnMove;
            inputActions.PlayerActions.Move.canceled += OnMove;
            if(controller != null)
            {

            inputActions.PlayerActions.Jump.started += ctx => controller.Jump();

            inputActions.PlayerActions.Attack.canceled += ctx => controller.Attacks();

            inputActions.PlayerActions.Portal.started += ctx => controller.PortalDirect(stickDirection);

            }
            inputActions.PlayerActions.StickRotation.started += StickDirection;
            inputActions.PlayerActions.StickRotation.performed += StickDirection;
            inputActions.PlayerActions.StickRotation.canceled += StickDirection;

            inputActions.Enable();
        }

        private void StickDirection(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            stickDirection = obj.ReadValue<Vector2>();
        }

        private void OnMove(UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
            moveInput = context.ReadValue<float>();
            if (moveInput == 0 || IsStickBackwards())
            {
                //Debug.Log("LoseSpeed from stick");
                loseSpeed = true;
            }
            else
                loseSpeed = false;
        }
        public bool IsStickBackwards()
        {
           // print((moveInput / Mathf.Abs(moveInput)) + "  " + (speed.speed.x / Mathf.Abs(speed.speed.x)));
            return moveInput != 0 && moveInput / Mathf.Abs(moveInput) != speed.speed.x / Mathf.Abs(speed.speed.x);
        }
        
        public Vector2 getStickAxis()
        {
            return stickDirection;
        }
        public float GetMove()
        {
            return moveInput;
        }
        // Update is called once per frame
        void Update()
        {

            if (moveInput == 0 || IsStickBackwards())
            {
                //Debug.Log("LoseSpeed from stick");
                loseSpeed = true;
            }
            else
                loseSpeed = false;
            if (!speed.rightStop[1] || (moveInput < 0 && speed.rightStop[0]) || (moveInput > 0 && !speed.rightStop[0]))
            {
                speed.gainSpeed();
                // Debug.Log("Lose Speed");
            }
            if(speed.isFalling || loseSpeed)
            {
                speed.loseSpeed();
            }
        }
    }
}
