using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPause : MonoBehaviour
{
    [SerializeField] private GameObject _buttonPause;
    [SerializeField] private GameObject _panelPause;

    public void Enable()
    {
        Time.timeScale = 0f;
        _panelPause.SetActive(true);
        _buttonPause.SetActive(false);
    }

    public void Disable()
    {
        Time.timeScale = 1f;
        _panelPause.SetActive(false);
        _buttonPause.SetActive(true);
    }
}
