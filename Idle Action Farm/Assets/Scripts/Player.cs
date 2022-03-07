using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FloatingJoystick _joystick;
    [SerializeField] private float speed;

    private PlayerAnimations _playerAnimations;

    private void Start() {
        _playerAnimations = GetComponent<PlayerAnimations>();
    }

    private void FixedUpdate() {
        if (_joystick.Horizontal != 0 && _joystick.Vertical != 0 && !_playerAnimations.isStait())
            _rigidbody.velocity = new Vector3(_joystick.Horizontal * speed, 0, _joystick.Vertical * speed);
        else
            _rigidbody.velocity = new Vector3(_joystick.Horizontal / (speed * 2) , 0, _joystick.Vertical / (speed * 2));

        if (_joystick.Horizontal != 0 && _joystick.Vertical != 0){
            
            //_animator.SetBool("isWalking", true);
            //transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            transform.rotation = Quaternion.LookRotation(new Vector3(_joystick.Horizontal * speed, 0, _joystick.Vertical * speed));
            _playerAnimations.SetAnim(PlayerAnimations.Anim.Walking);
            
        }
        else{
            //_animator.SetBool("isWalking", false);
            _playerAnimations.SetAnim(PlayerAnimations.Anim.Standing);
        }
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Whea")){
            Destroy(other.gameObject);
            //other.GetComponent<Transform>().position = new Vector3(0, 10, 0);
            //_animator.SetTrigger("Discharge");
            _playerAnimations.SetAnim(PlayerAnimations.Anim.Discharge);
        }
        print("Enter");
    }
}
