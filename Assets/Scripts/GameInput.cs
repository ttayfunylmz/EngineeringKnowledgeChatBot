using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    public static GameInput Instance;

    private PlayerInputActions playerInputActions;

    [HideInInspector] public Vector2 inputVector;
    private bool isRunPressed;

    private void Awake()
    {
        Instance = this;

        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
    }
    public Vector2 GetMovementVectorNormalized()
    {
        inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();
        isRunPressed = inputVector.x != 0 || inputVector.y != 0; //For animation
        inputVector = inputVector.normalized;
        return inputVector;
    }

    public bool IsPlayerRunning()
    {
        return isRunPressed;
    }
}
