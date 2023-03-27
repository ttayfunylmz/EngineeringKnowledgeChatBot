using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const string IS_RUNNING = "IsRunning";

    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private GameInput gameInput;
    [SerializeField] private Animator animator;

    private void Update()
    {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();

        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.position += moveDir *moveSpeed * Time.deltaTime;

        // float rotateSpeed = 10f;
        // transform.forward = Vector3.Slerp(transform.forward ,  moveDir, Time.deltaTime * rotateSpeed);

        MovementAnimationHandler();
        MovementRotationHandler();
    }

    private void MovementRotationHandler()
    {
        Vector3 currentPosition = transform.position;
        Vector3 newPosition = new Vector3(GameInput.Instance.inputVector.x, 0f, GameInput.Instance.inputVector.y);
        Vector3 positionToLookAt = currentPosition + newPosition;
        transform.LookAt(positionToLookAt);
    }

    private void MovementAnimationHandler()
    {
        if(GameInput.Instance.IsPlayerRunning())
        {
            animator.SetBool(IS_RUNNING, true);
        }

        if(!GameInput.Instance.IsPlayerRunning())
        {
            animator.SetBool(IS_RUNNING, false);
        }
    }


}
