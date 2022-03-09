using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerSpace;

[RequireComponent (typeof(Animator))]
public class PlayerAnimations : MonoBehaviour
{
    private Animator _animator;
    private IPlayerAnim? _anim;

    private void Start() {
        _animator = GetComponent<Animator>();
        SetAnim(new Walk());
    }

    public void SetAnim(IPlayerAnim? anim){
        if (!(_anim is null)){
            _animator.SetBool(_anim.State, false);
            _animator.SetBool(_anim.Move, false);
        }

        _anim = anim;

        _animator.SetBool(_anim.State, true);
    }

    public void Move(){

        if (_anim is null){
            print("нету анимации");
            return;
        }

        print(_anim.Move);

        _animator.SetBool(_anim.Move, true);
    }

    public void State(){
        if (_anim is null){
            print("нету анимации");
            return;
        }

        print(_anim.State);

        _animator.SetBool(_anim.Move, false);
    }
}
