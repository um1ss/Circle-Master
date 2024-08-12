using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class UIButtonQuitFromTableSkins : MonoBehaviour
{
    [SerializeField] private RectTransform _uiRectTransform;
    [SerializeField] private float _animationDuration;
    [SerializeField] private float _howManyMetersLetGo;

    public void AnimationDown()
    {
        if (UIButtonEnterToTableSkins._isOn)
        {
            _uiRectTransform.DOAnchorPosY(_uiRectTransform.anchoredPosition.y - _howManyMetersLetGo, _animationDuration)
                .SetEase(Ease.OutQuint);
            UIButtonEnterToTableSkins._isOn = false;
        }
    }
}
