using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(BoxCollider))]
public class Whea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.GetComponent<PlayerAnimations>() is null) return;

        Debug.Log("Player Zona");
    }

    public void Cut(){
        Destroy(this.gameObject);
    }
}
