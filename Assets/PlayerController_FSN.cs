using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_FSN : MonoBehaviour
{



    public float nextFire;


    public Animator animator;

    public Transform shotSpawn;
    public float fireRate;

    public float max_speed;
    public float cur_speed;
    public bool isJumping;
    private Rigidbody rbody;

    public Rigidbody Rigidbody
    {

        get { return rbody;}

    }

    private PlayerBaseState currentPlayerState;


    public readonly PlayerIdleState idleState= new PlayerIdleState();

    public readonly PlayerWalkState WalkState = new PlayerWalkState();
    public readonly PlayerJumpingState JumpingState = new PlayerJumpingState();
    public readonly PlayerCrouchingState CrouchingState = new PlayerCrouchingState();
    public readonly PlayerFlyingState FlyingState = new PlayerFlyingState();
    public readonly PlayerFallingState FallingState = new PlayerFallingState();

    public float jumpForce;






    // Start is called before the first frame update
    private void Awake()
    {
        rbody = GetComponent<Rigidbody>();

    }
    // Start is called before the first frame update
    private void Start()
    {
        TransitionToState(FallingState);
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
