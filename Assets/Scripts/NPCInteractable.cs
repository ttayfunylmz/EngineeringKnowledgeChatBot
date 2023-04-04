using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Cinemachine;

public class NPCInteractable : MonoBehaviour, IInteractable
{
    public static NPCInteractable Instance { get; private set; }

    [TextArea(2, 5)]
    [SerializeField] private string interactText;
    [SerializeField] private GameObject chatPart;
    [SerializeField] private GameObject interactContainer;
    [SerializeField] private float fadeDuration = 0.5f;

    [SerializeField] private GameObject player;
    [SerializeField] private CinemachineFreeLook freeLookCamera;

    private void Awake() 
    {
        Instance = this;
    }

    public void Interact()
    {
        ShowChatPart();
    }

    public string GetInteractText()
    {
        return interactText;
    }

    public Transform GetTransform()
    {
        return transform;
    }

    private void ShowChatPart()
    {
        chatPart.SetActive(true);
        chatPart.GetComponent<CanvasGroup>().DOFade(1f, fadeDuration);
        interactContainer.SetActive(false);

        //Disable player controls and camera
        freeLookCamera.enabled = false;
        player.GetComponent<PlayerController>().enabled = false;
    }

    public void HideChatPart()
    {
        interactContainer.SetActive(true);
        chatPart.GetComponent<CanvasGroup>().DOFade(0f, fadeDuration).OnComplete(() =>
        {
            chatPart.SetActive(false);
        });

        //Enable player controls and camera
        freeLookCamera.enabled = true;
        player.GetComponent<PlayerController>().enabled = true;
    }
}
