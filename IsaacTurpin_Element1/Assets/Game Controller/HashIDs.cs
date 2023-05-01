using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashIDs : MonoBehaviour
{
    public int speedFloat;
    public int backwardsBool;
    public int walkState;
    public int runState;
    public int jumpingBool;
    public int landedBool;
    public int attackingBool;
    public int hitBool;
    public int deadBool;
    public int dyingState;
    private void Awake()
    {
        speedFloat = Animator.StringToHash("Speed");
        backwardsBool = Animator.StringToHash("Backwards");
        walkState = Animator.StringToHash("Walk");
        runState = Animator.StringToHash("RunForward");
        jumpingBool = Animator.StringToHash("Jumping");
        landedBool = Animator.StringToHash("Landed");
        attackingBool = Animator.StringToHash("Attacking");
        hitBool = Animator.StringToHash("Hit");
        deadBool = Animator.StringToHash("Dead");
        dyingState = Animator.StringToHash("Dying");
        
    }
}
