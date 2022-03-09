using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody), typeof(PlayerAnimations))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private FloatingJoystick _joystick;
    [SerializeField] private float speed;

    private Rigidbody _rigidbody;
    private PlayerAnimations _playerAnimations;

    private void Start() {
        _rigidbody = GetComponent<Rigidbody>();
        _playerAnimations = GetComponent<PlayerAnimations>();
        
    }

    private void FixedUpdate() {

        if (_joystick.Horizontal != 0 && _joystick.Vertical != 0){
            if (_playerAnimations.Move()){
                _rigidbody.velocity = new Vector3(_joystick.Horizontal * speed, 0, _joystick.Vertical * speed);
                transform.rotation = Quaternion.LookRotation(new Vector3(_joystick.Horizontal * speed, 0, _joystick.Vertical * speed));
            }
        }
        else{
            _playerAnimations.State();
        }
    }
}