using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class UIButtonEnterToTableSkins : MonoBehaviour
{
    [SerializeField] private SkinsManager _skinsManager;
    [SerializeField] private RectTransform _uiRectTransform;
    [SerializeField] private float _animationDuration;
    [SerializeField] private float _howManyMetersRaise;

    public static bool _fromARCADEScene;
    public static bool _isOn;

    private void Awake()
    {
        _isOn = false;
    }

    private void Start()
    {
        if (_fromARCADEScene)
        {
            AnimationUp();
            _fromARCADEScene = false;
        }
    }

    private void Update()
    {
        _skinsManager.CheckingScoresPlayer();
        _skinsManager.UpdateBestPlayerScores();
        _skinsManager.CheckingWhichSkinIsSelected();
        _skinsManager.CheckingOpenSkinOrNot();
        _skinsManager.CheckingAdvertisementWasViewed();
        _skinsManager.UpdateText();
    }

    public void AnimationUp()
    {
        if (!_isOn)
        {
            _uiRectTransform.DOAnchorPosY(_uiRectTransform.anchoredPosition.y + _howManyMetersRaise, _animationDuration)
                .SetEase(Ease.OutQuint);
            _isOn = true;
        }
    }
}
