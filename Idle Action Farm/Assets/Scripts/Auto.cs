using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")){
            foreach (Crop crop in Resources.FindObjectsOfTypeAll(typeof(Crop)) as Crop[])
            {
                crop.target = _target;
            }
        }
    }
}
