using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerSpace;

public class Sickle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Whea"))
            print("Whea kill");
    }
}
