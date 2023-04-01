using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatUI : MonoBehaviour
{
    [SerializeField] private Button crossButton;

    private void Start() 
    {
        crossButton.onClick.AddListener(OnCrossButtonClick);
    }

    public void OnCrossButtonClick()
    {
        NPCInteractable.Instance.HideContainer();
    }
}
