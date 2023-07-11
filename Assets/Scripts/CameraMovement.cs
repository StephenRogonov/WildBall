using UnityEngine;

namespace WildBall
{
    public class CameraMovement : MonoBehaviour
    {
        [SerializeField] private Transform _playerTransform;

        private Vector3 _offset;

        private float _smoothFactor = 0.5f;

        private void Start()
        {
            _offset = transform.position - _playerTransform.position;
        }

        private void LateUpdate()
        {
            Vector3 newPosition = _playerTransform.position + _offset;
            transform.position = Vector3.Slerp(transform.position, newPosition, _smoothFactor);
        }
    }
}
