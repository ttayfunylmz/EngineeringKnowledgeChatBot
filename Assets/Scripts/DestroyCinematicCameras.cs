using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class DestroyCinematicCameras : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera cinematicCamera1;
    [SerializeField] private CinemachineVirtualCamera cinematicCamera2;

    private void Start() 
    {
        Destroy(cinematicCamera1, 7f);
        Destroy(cinematicCamera2, 7f);
    }

    private void DestroyCameras()
    {
        
    }
}
