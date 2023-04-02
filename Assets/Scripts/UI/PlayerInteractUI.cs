using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class PlayerInteractUI : MonoBehaviour
{
    [SerializeField] private GameObject container;
    [SerializeField] private PlayerInteract playerInteract;
    [SerializeField] private TextMeshProUGUI interactText;
    [SerializeField] private float fadeDuration = 1f;

    private void Update() 
    {
        if(playerInteract.GetInteractableObject() != null)
        {
            Show(playerInteract.GetInteractableObject());
        }
        else
        {
            Hide();
        }
    }

    private void Show(IInteractable interactable)
    {
        container.GetComponent<CanvasGroup>().DOFade(1f, fadeDuration);
        interactText.text = interactable.GetInteractText();
    }

    private void Hide()
    {
        container.GetComponent<CanvasGroup>().DOFade(0f, fadeDuration);
    }
}
