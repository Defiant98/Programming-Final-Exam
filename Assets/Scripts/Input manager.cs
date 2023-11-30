using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{
    private static BallController _ballController;

    public static void Init(Player myPlayer)
    {
        _ballController = new BallController();
       _ballController.Permanent.Enable();
        _ballController.InGame.XMovement.performed += ctx =>
        {
            myPlayer.SetMovementDirection(ctx.ReadValue<Vector3>());
        };
    }

    public static void SetBallController()
    {
        _ballController.InGame.Enable();
        _ballController.UI.Disable();
    }

    public static void SetUIControls()
    {
        _ballController.UI.Enable();
        _ballController.InGame.Disable();
    }
    
}
