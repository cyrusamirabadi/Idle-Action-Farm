using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(BoxCollider))]
public class Whea : MonoBehaviour
{
    [SerializeField] private GameObject _crap;
    //TODO для теста
    public void Cut(){
        FindObjectOfType<Points>().Add();
        Instantiate(_crap).GetComponent<Transform>().position = 
            new Vector3(transform.position.x, _crap.GetComponent<Transform>().position.y, transform.position.z);
        Destroy(this.gameObject);
    }
}
