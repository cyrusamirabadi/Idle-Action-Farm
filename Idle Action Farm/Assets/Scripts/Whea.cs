using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(BoxCollider))]
public class Whea : MonoBehaviour
{
    [SerializeField] private GameObject _crap;
    
    private bool isGrowth = false;
    private bool IsGrowth{
        get => isGrowth;
        set{
            GetComponent<BoxCollider>().enabled = !value;
            isGrowth = value;
        }
    }
    private float speed = 0.03f;
    public Transform target;
    public void Cut(){
        if (FindObjectOfType<GameManager>().AddCrop() && !IsGrowth){
            FindObjectOfType<Points>().Add();
            Instantiate(_crap).GetComponent<Transform>().position = 
                new Vector3(transform.position.x, _crap.GetComponent<Transform>().position.y, transform.position.z);
            //Destroy(this.gameObject);
            GameObject gm = new GameObject();
            gm.transform.position = this.transform.position;
            gm.transform.rotation = this.transform.rotation;

            target = Instantiate(gm).GetComponent<Transform>();
            IsGrowth = true;

            transform.position = 
                new Vector3(transform.position.x, transform.position.y - transform.position.y * 2, transform.position.z);
        }
    }

    private void Update() {
        if (IsGrowth){
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            if (transform.position == target.position) {
                Destroy(target.gameObject);
                IsGrowth = false;
            }
        }
    }
}
