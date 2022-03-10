using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int MaxCrop;
    private int CountCrop = 0;

    public bool AddCrop(){
        CountCrop++;
        if (CountCrop >= MaxCrop) return false;
        return true;
    }
    
    public void ResetCrop() => CountCrop = 0;
}
