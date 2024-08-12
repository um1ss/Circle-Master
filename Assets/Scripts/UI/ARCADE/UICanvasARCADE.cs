using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using YG;

public class UICanvasARCADE : MonoBehaviour
{
    [SerializeField] private GameObject _buttonNewSkin;

    [SerializeField] private GameObject _panelUICanvas;
    [SerializeField] private Button _buttonCheckMarketing;
    [SerializeField] private Button _buttonRestart;
    [SerializeField] private Button _buttonQuit;

    [SerializeField] private int _attemptsViewAds;

    [SerializeField] private RectTransform uiElement;
    [SerializeField] private float targetScale = 2f;
    [SerializeField] private float duration = 1f;

    private void Awake()
    {
        EventBusARCADE.Instance.GameIsOver += Enable;
        EventBusARCADE.Instance.GameIsOver += CoolAppearance;
        EventBusARCADE.Instance.GameContinued += Disabled;
        EventBusARCADE.Instance.GameHasReloaded += Disabled;
        EventBusARCADE.Instance.GameContinued += ResetScaleLeaderBord;
        EventBusARCADE.Instance.GameHasReloaded += ResetScaleLeaderBord;
        YandexGame.RewardVideoEvent += ViewAdvReward;
    }

    private void Update()
    {
        if (_attemptsViewAds <= 0)
        {
            _buttonCheckMarketing.enabled = false;
        }
    }

    public void EnableButtonNewSkin()
    {
        _buttonNewSkin.SetActive(true);
        _buttonCheckMarketing.transform.localPosition = new Vector2(247.5f, -813f);
        _buttonRestart.transform.localPosition = new Vector2(-246.5f, -813f);
        _buttonQuit.transform.localPosition = new Vector2(0, -813f);
    }

    public void DisableButtonNewSkin()
    {
        _buttonNewSkin.SetActive(false);
        _buttonCheckMarketing.transform.localPosition = new Vector2(247.5f, -597);
        _buttonRestart.transform.localPosition = new Vector2(-246.5f, -597);
        _buttonQuit.transform.localPosition = new Vector2(0, -597);
    }

    public void RateGame()
    {
        YandexGame.ReviewShow(YandexGame.EnvironmentData.reviewCanShow);
    }

    public void RestartGame()
    {
        EventBusARCADE.Instance.GameHasReloaded?.Invoke();
    }

    public void ViewAdv()
    {
        YandexGame.RewVideoShow(1);
    }
    
    private void ViewAdvReward(int id)
    {
        if (id == 1)
        {
            _attemptsViewAds -= 1;
            EventBusARCADE.Instance.GameContinued?.Invoke();
        }
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
        EventBusARCADE.Instance.GameIsOver -= Enable;
        EventBusARCADE.Instance.GameIsOver -= CoolAppearance;
        EventBusARCADE.Instance.GameContinued -= Disabled;
        EventBusARCADE.Instance.GameHasReloaded -= Disabled;
        EventBusARCADE.Instance.GameContinued -= ResetScaleLeaderBord;
        EventBusARCADE.Instance.GameHasReloaded -= ResetScaleLeaderBord;
        YandexGame.RewardVideoEvent -= ViewAdvReward;
    }
}
