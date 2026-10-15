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

        
        //[SerializeField] private Planet[] _planetArray = new Planet[5];

        private void Start()
        {
            for (int i = 0; i < _planetCount; i++)
            {
                // TODO: create a planet
                
                var planetObject = new GameObject($"Planet {i}");
                Planet planet = planetObject.AddComponent<Planet>();
                planet.transform.parent = gameObject.transform;
                planet.CenterOfRotation = gameObject;
                planet.Speed = UnityEngine.Random.Range(0.1f, 1f);
                planet.Size = UnityEngine.Random.Range(0.5f, 2f);
                planet.Distance = UnityEngine.Random.Range(5f, 20f);
                _planetList.Add(planet);
                _planetList[i].Color = Color.HSVToRGB(UnityEngine.Random.value, 1f, 1f);
                Debug.Log(_planetList[i].name);
            }
            //_planetList.Add(new Planet());
        }
        
        private void OnDrawGizmos()
        {
            Gizmos.color = _sunColor;
            Gizmos.DrawSphere(transform.position, _sunSize);
        }
    }
}