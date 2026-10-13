using UnityEngine;

namespace Revision
{
    public class Planet : MonoBehaviour
    {
        [SerializeField] private GameObject _centerOfRotation;
        
        [SerializeField] private Color _color = Color.red;
        [SerializeField] private float _size = 1f;
        [SerializeField] private float _speed = 1f;
        
        private void Start()
        {
            Debug.Log("Planet started");
        }

        private void Update()
        {
            // Version
            transform.RotateAround(_centerOfRotation.transform.position, Vector3.up, _speed);
            
            // Version 2
            // var valZ = Mathf.Sin(Time.time * 2);
            // var valX = Mathf.Cos(Time.time * 2);
            
            // transform.position = new Vector3(valX *2, transform.position.y, valZ);
        }

        private void OnDestroy()
        {
            
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = _color;
            Gizmos.DrawSphere(transform.position, _size);
        }
    }
}