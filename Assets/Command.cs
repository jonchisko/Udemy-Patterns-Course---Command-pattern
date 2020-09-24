using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    public abstract void Execute(Animator anim);
    public abstract void Undo(Animator anim);
}


public class PerformJump: Command
{
    public override void Execute(Animator anim)
    {
        anim.SetTrigger("isJumping");
    }

    public override void Undo(Animator anim)
    {
        anim.SetTrigger("isJumpingR");
    }
}

public class DoNothing : Command
{
    public override void Execute(Animator anim)
    {
        Debug.Log("DoNothing::Execute -> does nothing.");
    }

    public override void Undo(Animator anim)
    {
        Debug.Log("DoNothing::Execute -> does nothing.");
    }
}

public class PerformKick : Command
{
    public override void Execute(Animator anim)
    {
        anim.SetTrigger("isKicking");
    }

    public override void Undo(Animator anim)
    {
        anim.SetTrigger("isKickingR");
    }
}

public class PerformPunch : Command
{
    public override void Execute(Animator anim)
    {
        anim.SetTrigger("isPunching");
    }

    public override void Undo(Animator anim)
    {
        anim.SetTrigger("isPunchingR");
    }
}


public class MoveForward : Command
{
    public override void Execute(Animator anim)
    {
        anim.SetTrigger("isWalking");
    }

    public override void Undo(Animator anim)
    {
        anim.SetTrigger("isWalkingR");
    }
}


