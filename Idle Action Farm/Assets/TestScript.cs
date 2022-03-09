using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerSpace;

public class TestScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        other.gameObject.GetComponent<PlayerAnimations>().SetAnim(new Dance());
        
    }
}
