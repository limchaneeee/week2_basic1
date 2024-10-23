using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0;
    private Animator _animatior;

    private void Awake()
    {
        _animatior = GetComponent<Animator>();
    }


    private void OnMouseDown()
    {
        _animatior.SetInteger("State", animationVariable);

        animationVariable++;
        if (animationVariable > 2)
        {
            animationVariable = 0;
        }
    }
}
