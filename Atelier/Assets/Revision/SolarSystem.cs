using System;
using System.Collections.Generic;
using UnityEngine;

namespace Revision
{
    public class SolarSystem : MonoBehaviour
    {
        [SerializeField] private Color _sunColor = Color.yellowNice;
        [SerializeField] private float _sunSize = 3f;
        
        //[SerializeField] private List<Planet> _planetList;
        [SerializeField] private Planet[] _planetArray = new Planet[5];

        private void Start()
        {
            for (int i = 0; i < _planetArray.Length; i++)
            {
                // TODO: assigner une couleur aléatoire à chaque planète
                _planetArray[i].Color = Color.HSVToRGB(UnityEngine.Random.value, 1f, 1f);
                Debug.Log(_planetArray[i].name);
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