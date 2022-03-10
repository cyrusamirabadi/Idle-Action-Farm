using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private int MaxCrop;

    private int count = 0;
    public int Count{
        get => count;
        set {
            slider.value = value;

            if (value == slider.maxValue){
                count = 0;
                FindObjectOfType<Points>().Add();
            }else{
                count = value;
            }
        }
    }
    private int CountCrop = 0;

    public bool AddCrop(){
        if (CountCrop >= MaxCrop) return false;
        CountCrop++;
        Count++;
        return true;
    }
    
    public void ResetCrop() => CountCrop = 0;
}
