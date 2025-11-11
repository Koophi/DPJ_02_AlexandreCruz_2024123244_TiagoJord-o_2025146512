using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public readonly int moveX = Animator.StringToHash("MoveX");
    public readonly int moveY = Animator.StringToHash("MoveY");
    public readonly int moving = Animator.StringToHash("Moving");
    public readonly int dead = Animator.StringToHash("Dead");

    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void SetDeadAnimation()
    {
        animator.SetTrigger(dead);
    }

    public void SetMoveBoolTransition(bool value)
    {
        animator.SetBool(moving, value);
    }

    public void SetMoveAnimation(Vector2 dir)
    {
        animator.SetFloat(moveX, dir.x);
        animator.SetFloat(moveY, dir.y);
    }
}

