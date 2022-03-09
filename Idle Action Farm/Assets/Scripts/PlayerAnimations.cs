using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerSpace;

[RequireComponent (typeof(Animator))]
public class PlayerAnimations : MonoBehaviour
{
    private Animator _animator;
    private IPlayerAnim? _anim;

    public bool isState {get; private set;}

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

    public bool Move(){
        if (_anim is null || _anim.Move is null){
            return false;
        }

        _animator.SetBool(_anim.Move, true);

        isState = false;

        return true;
    }

    public void State(){
        if (_anim is null){
            Debug.LogError("_anim is null");
            return;
        }

        _animator.SetBool(_anim.Move, false);

        isState = true;
    }
}
