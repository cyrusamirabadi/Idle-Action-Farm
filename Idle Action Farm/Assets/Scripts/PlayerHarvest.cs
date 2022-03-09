using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerSpace;

public class PlayerHarvest : MonoBehaviour
{
    private const int timerValue = 2; 
    private float timer = timerValue;
    private bool isHarvest = false;
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Whea") && !isHarvest){
            GetComponent<PlayerAnimations>().SetAnim(new Harvest());
            isHarvest = true;
        }
    }

    private void Update() {
        if (isHarvest){
            timer -= Time.deltaTime;
            if (GetComponent<PlayerAnimations>().isState || timer <= 0){
                GetComponent<PlayerAnimations>().SetAnim(new Walk());
                isHarvest = false;
                timer = timerValue;
                return;
            }
        }
    }
}
