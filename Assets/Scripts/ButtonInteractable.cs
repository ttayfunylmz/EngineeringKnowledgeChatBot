using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private Transform carBarrier1;
    [SerializeField] private Transform carBarrier2;

    [SerializeField] private bool isBarrierLifted = true;

    public void Interact()
    {
        float rotateDuration = 2f;

        if(isBarrierLifted)
        {
            carBarrier1.DORotate(new Vector3(-90f, -90f, 0f), rotateDuration);
            carBarrier2.DORotate(new Vector3(-90f, 90f, 0f), rotateDuration);
            isBarrierLifted = false;
        }
        else if(!isBarrierLifted)
        {
            carBarrier1.DORotate(new Vector3(0f, -90f, 0f), rotateDuration);
            carBarrier2.DORotate(new Vector3(0f, 90f, 0f), rotateDuration);
            isBarrierLifted = true;
        }
    }

    public string GetInteractText()
    {
        return "Push to Button to lift the baricade up!";
    }

    public Transform GetTransform()
    {
        return transform;
    }

    
}
