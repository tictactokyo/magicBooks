using UnityEngine;

public abstract class PlayerBaseState 
{

   
    public abstract void EnterState(PlayerController_FSN player);
    public abstract void Update(PlayerController_FSN player);
    public abstract void OnCollisionEnter(PlayerController_FSN player);
}
