using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const string IS_RUNNING = "IsRunning";

    [SerializeField] private float rotateSpeed = 10f;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private GameInput gameInput;
    [SerializeField] private Animator animator;

    private Transform cameraMainTransform;

    private void Awake() 
    {
        cameraMainTransform = Camera.main.transform;
    }

    private void Update()
    {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();

        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        moveDir = cameraMainTransform.forward * moveDir.z + cameraMainTransform.right * moveDir.x;
        moveDir.y = 0f;

        transform.position += moveDir *moveSpeed * Time.deltaTime;

        transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * rotateSpeed);

        MovementAnimationHandler();
    }

    private void MovementAnimationHandler()
    {
        if(gameInput.IsPlayerRunning())
        {
            animator.SetBool(IS_RUNNING, true);
        }

        if(!gameInput.IsPlayerRunning())
        {
            animator.SetBool(IS_RUNNING, false);
        }
    }


}
