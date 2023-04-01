using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NPCInteractable : MonoBehaviour, IInteractable
{
    public static NPCInteractable Instance { get; private set; }

    [TextArea(2, 5)]
    [SerializeField] private string interactText;
    [SerializeField] private GameObject chatContainer;
    [SerializeField] private GameObject interactContainer;
    [SerializeField] private float fadeDuration = 0.5f;

    private void Awake() 
    {
        Instance = this;
    }

    public void Interact()
    {
        ShowContainer();
    }

    public string GetInteractText()
    {
        return interactText;
    }

    public Transform GetTransform()
    {
        return transform;
    }

    private void ShowContainer()
    {
        chatContainer.SetActive(true);
        chatContainer.GetComponent<CanvasGroup>().DOFade(1f, fadeDuration);
        interactContainer.SetActive(false);
    }

    public void HideContainer()
    {
        interactContainer.SetActive(true);
        chatContainer.GetComponent<CanvasGroup>().DOFade(0f, fadeDuration).OnComplete(() =>
        {
            chatContainer.SetActive(false);
        });

    }
}
