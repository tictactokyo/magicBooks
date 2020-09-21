using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrouchingState : PlayerBaseState
{
    public override void EnterState(PlayerController_FSN player)
    {
        player.animator.SetBool("isCrouching", true);
    }

    public override void OnCollisionEnter(PlayerController_FSN player)
    {
        throw new System.NotImplementedException();
    }

    public override void Update(PlayerController_FSN player)
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * player.max_speed;

        player.animator.SetFloat("Speed", Mathf.Abs(moveHorizontal));

        float moveVertical = Input.GetAxis("Vertical") * player.max_speed;

        Vector3 movement = new Vector3(moveHorizontal, -0.1f , 0.0f);

        player.Rigidbody.velocity = movement;//expand this out to a move in animated objects
        if (Input.GetKeyDown("q") && Time.time > player.nextFire)
        {

            player.TransitionToState(player.CrouchingState);

        }
        else if(Input.GetKeyDown("e") && Time.time > player.nextFire)
        {
            player.animator.SetBool("isCrouching", false);
            player.TransitionToState(player.FlyingState);

        }
    }
}
