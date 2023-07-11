using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float _speed = 2.0f;
        [SerializeField] private float _jumpForce = 5.0f;
        private Rigidbody _playerRigidbody;

        private void Awake()
        {
            _playerRigidbody = GetComponent<Rigidbody>();
        }

        public void MovePlayer(Vector3 movement)
        {
            _playerRigidbody.AddForce(movement * _speed);
        }

        public void Jump()
        {
            _playerRigidbody.AddForce(new Vector3(0, 1, 0).normalized * _jumpForce, ForceMode.Impulse);
        }

#if UNITY_EDITOR
        [ContextMenu("Reset values")]
        public void ResetValues()
        {
            _speed = 2;
        }
#endif
    }
}
