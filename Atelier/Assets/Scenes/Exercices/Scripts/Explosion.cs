using System;
using UnityEngine;

namespace Scenes.Exercices.Scripts
{
    public class Explosion : MonoBehaviour
    {
        [SerializeField] private float _force = 15f;
        [SerializeField] private float _radius = 5f;
        [SerializeField] private float _upwards = 0.5f;

        [ContextMenu("Explode")]
        private void Explode()
        {
            var collider = Physics.OverlapSphere(transform.position, _radius);
            
            foreach (var col in collider)
            {
                if (col.attachedRigidbody)
                    col.attachedRigidbody.AddExplosionForce(_force, transform.position, _radius, _upwards, ForceMode.VelocityChange);
            }
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.DrawWireSphere(transform.position, _radius);
        }
    }
}