﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpingState : PlayerBaseState
{
    public override void EnterState(PlayerController_FSN player)
    {
        
    }

    public override void OnCollisionEnter(PlayerController_FSN player)
    {
        throw new System.NotImplementedException();
    }

    public override void Update(PlayerController_FSN player)
    {
        if (Input.GetButtonDown("jump"))
        {
            player.Rigidbody.AddForce(Vector3.up * player.jumpForce);
        }
    }
}
