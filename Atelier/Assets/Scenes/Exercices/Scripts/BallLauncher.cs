using UnityEngine;

namespace Scenes.Exercices.Scripts
{
    [RequireComponent(typeof(Rigidbody))]
    public class BallLauncher : MonoBehaviour
    {
        [SerializeField] private Vector3 _direction;
        [SerializeField] private float _impulse = 10f;
        
        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Start()
        {
            _rigidbody.AddForce(_direction * _impulse, ForceMode.Impulse);
        }
    }
}
