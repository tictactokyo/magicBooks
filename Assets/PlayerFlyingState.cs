using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlyingState : PlayerBaseState
{
    public override void EnterState(PlayerController_FSN player)
    {
        player.animator.SetBool("isFlying", true);
    }

    public override void OnCollisionEnter(PlayerController_FSN player)
    {
        throw new System.NotImplementedException();
    }

    public override void Update(PlayerController_FSN player)
    {


        if (Input.GetKeyDown("q") && Time.time > player.nextFire)
        {
            player.animator.SetBool("isFlying", false);
            player.TransitionToState(player.FallingState);

        }




        float moveHorizontal = Input.GetAxis("Horizontal") * player.max_speed;

        player.animator.SetFloat("Speed", Mathf.Abs(moveHorizontal));

        float moveVertical = Input.GetAxis("Vertical") * player.max_speed;

        Vector3 movement = new Vector3( moveHorizontal, moveVertical, 0.0f);

        player.Rigidbody.velocity = movement;//expand this out to a move in animated objects

        //GetComponent<Rigidbody>().position = new Vector3
        //	(
        //		Mathf.Clamp (GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax), 
        //		0.0f, 
        //		Mathf.Clamp (GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
        //	);

        //	GetComponent<Rigidbody>().rotation = Quaternion.Euler (0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt);
    }


}
