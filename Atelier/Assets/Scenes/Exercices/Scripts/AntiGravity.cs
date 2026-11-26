using UnityEngine;

namespace Scenes.Exercices.Scripts
{
    public class AntiGravity : MonoBehaviour
    {
        [SerializeField] private ForceMode _mode;

        private Rigidbody _rigidbody;
        private Vector3 _forceToApply;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            // Force to apply = masse (kg) * gravité (m/s²)
            var mass = 1f; // Default mass value

            // use mass only for ForceMode.Force or ForceMode.Impulse
            if (_mode is ForceMode.Force or ForceMode.Impulse)
                mass = _rigidbody.mass;
            _forceToApply = -Physics.gravity * mass;

            // Apply impulse or velocity change once
            if (_mode is ForceMode.Impulse or ForceMode.VelocityChange)
                _rigidbody.AddForce(_forceToApply, _mode);
        }

        private void FixedUpdate()
        {
            // Apply force or acceleration continuously
            if (_mode is ForceMode.Acceleration or ForceMode.Force)
                _rigidbody.AddForce(_forceToApply, _mode);
        }
    }
}