using System;
using UnityEngine;

namespace Revision
{
    [Serializable]
    public class Planet : MonoBehaviour
    {
        public GameObject CenterOfRotation { get; set; }

        // Property comme une variable
        public Color Color { get; set; }

        public float Size { get; set; }
        public float Speed { get; set; }
        public float Distance { get; set; }
        

        private void Start()
        {
            Debug.Log("Planet started");
            
            transform.position = CenterOfRotation.transform.position + Vector3.forward * Distance;
        }

        private void Update()
        {
            // Version
            transform.RotateAround(CenterOfRotation.transform.position, Vector3.up, Speed);

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
            Gizmos.color = Color;
            Gizmos.DrawSphere(transform.position, Size);
        }
    }
}