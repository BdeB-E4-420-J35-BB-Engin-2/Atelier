using System;
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