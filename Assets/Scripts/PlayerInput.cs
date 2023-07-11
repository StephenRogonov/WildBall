using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerInput : MonoBehaviour
    {
        private Vector3 _movement;
        private PlayerMovement _playerMovement;
        private bool isGrounded;

        private void Awake()
        {
            _playerMovement = GetComponent<PlayerMovement>();
        }

        private void OnTriggerStay(Collider other)
        {
            isGrounded = true;
        }

        private void OnTriggerExit(Collider other)
        {
            isGrounded = false;
        }

        private void Update()
        {
            float horizontal = Input.GetAxis(GlobalStringVars.HorizontalAxis);
            float vertical = Input.GetAxis(GlobalStringVars.VerticalAxis);

            _movement = new Vector3(vertical, 0, -horizontal).normalized;

            if (Input.GetButtonDown(GlobalStringVars.JumpButton) && isGrounded == true)
            {
                _playerMovement.Jump();
            }
        }

        private void FixedUpdate()
        {
            _playerMovement.MovePlayer(_movement);
        }
    }
}
