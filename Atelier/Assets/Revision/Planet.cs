using System;
using UnityEngine;

namespace Revision
{
    [Serializable]
    public class Planet : MonoBehaviour
    {
        public GameObject CenterOfRotation { get; set; }

        // Property comme une variable
        public Color Color { get; private set; }
        public float Size { get; private set; }
        public float Speed { get; private set; }
        public float Distance { get; private set; }

        private void Start()
        {
            Debug.Log("Planet started");
            Speed = UnityEngine.Random.Range(0.1f, 1f);
            Size = UnityEngine.Random.Range(0.5f, 2f);
            Distance = UnityEngine.Random.Range(5f, 20f);
            Color = Color.HSVToRGB(UnityEngine.Random.value, 1f, 1f);
            
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