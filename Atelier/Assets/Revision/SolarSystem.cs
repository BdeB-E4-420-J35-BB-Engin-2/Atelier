using System;
using System.Collections.Generic;
using UnityEngine;

namespace Revision
{
    public class SolarSystem : MonoBehaviour
    {
        [SerializeField] private Color _sunColor = Color.yellowNice;
        [SerializeField] private float _sunSize = 3f;
        
        [SerializeField] private List<Planet> _planetList;
        [SerializeField] private int _planetCount = 5;
        [SerializeField] private Planet _planetPrefab;

        
        //[SerializeField] private Planet[] _planetArray = new Planet[5];

        private void Start()
        {
            for (var i = 0; i < _planetCount; i++)
            {
                var planet = Instantiate(_planetPrefab, Vector3.zero, Quaternion.identity, gameObject.transform);
                planet.name = $"Planet {i}";
                planet.CenterOfRotation = gameObject;
                _planetList.Add(planet);
                Debug.Log(_planetList[i].name);
            }
        }
        
        private void OnDrawGizmos()
        {
            Gizmos.color = _sunColor;
            Gizmos.DrawSphere(transform.position, _sunSize);
        }
    }
}