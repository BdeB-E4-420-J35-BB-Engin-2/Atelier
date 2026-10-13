using UnityEngine;

namespace Revision
{
    public class Planet : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log("Planet started");
        }

        private void Update()
        {
            // Version
            transform.RotateAround(Vector3.zero, Vector3.up, 1f);
            
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
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(transform.position, 1f);
        }
    }
}