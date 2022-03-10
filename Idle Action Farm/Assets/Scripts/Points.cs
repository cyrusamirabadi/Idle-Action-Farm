using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    private TextMeshProUGUI _points;

    private int count = 0;
    public int Count { 
        get => count;
        set {
            count += value * 5;
            _points.text = count.ToString();
        }
    }
    void Start()
    {
        _points = GetComponent<TextMeshProUGUI>();
        Count = 0;
    }

    public void Add() => Count = 1;
}
