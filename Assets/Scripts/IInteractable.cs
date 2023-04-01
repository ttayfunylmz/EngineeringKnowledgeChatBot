using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    void Interact();
    string GetInteractText();
    Transform GetTransform();
}
