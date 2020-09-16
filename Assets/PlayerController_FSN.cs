using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_FSN : MonoBehaviour
{


    private PlayerBaseState currentPlayerState;


    public readonly PlayerIdleState idleState= new PlayerIdleState();

    public readonly PlayerWalkState WalkState = new PlayerWalkState();
    public readonly PlayerJumpingState JumpingState = new PlayerJumpingState();
    public readonly PlayerCrouchingState CrouchingState = new PlayerCrouchingState();






    // Start is called before the first frame update
    private void Awake()
    {


    }
    // Start is called before the first frame update
    private void Start()
    {
        TransitionToState(idleState);
    }

    // Update is called once per frame
    private void Update()
    {
        currentPlayerState.Update(this);
    }
    public void TransitionToState(PlayerBaseState state)
    {
        currentPlayerState = state;
        currentPlayerState.EnterState(this);

    }
    private void OnCollisionEnter(Collision collision)
    {
        currentPlayerState.OnCollisionEnter(this);
    }






}
