using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsMenuManager : MonoBehaviour
{
    public void LoadScenes(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
