using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    [Header("Credits Robot Elements")]
    [SerializeField] private RectTransform creditsRobot;
    [SerializeField] private TextMeshProUGUI creditsText;

    [Header("Question Robot Elements")]
    [SerializeField] private RectTransform askQuestionRobot;
    [SerializeField] private TextMeshProUGUI askQuestionText;

    [Header("Durations")]
    [SerializeField] private float animateDuration = 1f;

    public void LoadScenes(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }

    public void OpenLinks(string link)
    {
        Application.OpenURL(link);
    }

    public void AnimateQuestionButton()
    {
        askQuestionRobot.DOAnchorPosX(880f, animateDuration);
        askQuestionText.GetComponent<CanvasGroup>().DOFade(1f, animateDuration);
    }

    public void ResetQuestionButtonAnimation()
    {
        askQuestionRobot.DOAnchorPosX(1000f, animateDuration);
        askQuestionText.GetComponent<CanvasGroup>().DOFade(0f, animateDuration);
    }

    public void AnimateCreditsButton()
    {
        creditsRobot.DOAnchorPosX(-880f, animateDuration);
        creditsText.GetComponent<CanvasGroup>().DOFade(1f, animateDuration);
    }

    public void ResetCreditsButtonAnimation()
    {
        creditsRobot.DOAnchorPosX(-1000f, animateDuration);
        creditsText.GetComponent<CanvasGroup>().DOFade(0f, animateDuration);
    }
}
