using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public enum Anim
    {
        Standing,
        Walking,
        Discharge,
        Halking,
        Win
    }

    public Anim AnimPlay { get; private set; }

    public void SetAnim(Anim anim){
        AnimPlay = anim;
        switch (anim){
            case Anim.Standing:
                _animator.SetBool("isWalking", false);
            break;
            case Anim.Walking:
                if (!isStait())
                    _animator.SetBool("isWalking", true);
            break;
            case Anim.Discharge:
                _animator.SetTrigger("Discharge");
            break;
        }
    }

    public bool isStait() => _animator.GetCurrentAnimatorStateInfo(0).IsName("Discharge");

}
