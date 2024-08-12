using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class UICanvas : MonoBehaviour
{
    [SerializeField] private GameObject _panelUICanvas;

    [SerializeField] private RectTransform uiElement;
    [SerializeField] private float targetScale = 2f;
    [SerializeField] private float duration = 1f;

    private void Awake()
    {
        EventBus1VS1.Instance.GameIsOver += Enable;
        EventBus1VS1.Instance.GameIsOver += CoolAppearance;
        EventBus1VS1.Instance.GameHasReloaded += Disabled;
        EventBus1VS1.Instance.GameHasReloaded += ResetScaleLeaderBord;
    }

    public void RateGame()
    {
        YandexGame.ReviewShow(YandexGame.EnvironmentData.reviewCanShow);
    }

    public void RestartGame()
    {
        EventBus1VS1.Instance.GameHasReloaded?.Invoke();
    }

    private void Enable()
    {
        _panelUICanvas.SetActive(true);
    }

    private void Disabled()
    {
        _panelUICanvas.SetActive(false);
    }

    private void CoolAppearance()
    {
        uiElement.DOScale(targetScale, duration)
            .SetEase(Ease.OutQuad);
    }

    private void ResetScaleLeaderBord()
    {
        uiElement.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }

    private void OnDestroy()
    {
        EventBus1VS1.Instance.GameIsOver -= Enable;
        EventBus1VS1.Instance.GameIsOver -= CoolAppearance;
        EventBus1VS1.Instance.GameHasReloaded -= Disabled;
        EventBus1VS1.Instance.GameHasReloaded -= ResetScaleLeaderBord;
    }
}
