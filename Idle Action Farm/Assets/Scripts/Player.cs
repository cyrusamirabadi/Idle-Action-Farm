using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FloatingJoystick _joystick;
    [SerializeField] private Animator _animator;
    [SerializeField] private float speed;

    private void FixedUpdate() {
        
        if (_joystick.Horizontal != 0 && _joystick.Vertical != 0)
            _rigidbody.velocity = new Vector3(_joystick.Horizontal * speed, 0, _joystick.Vertical * speed);
        if (_joystick.Horizontal != 0 && _joystick.Vertical != 0){
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            _animator.SetBool("isWalking", true);
            
        }
        else{
            _animator.SetBool("isWalking", false);
        }
    }
}
