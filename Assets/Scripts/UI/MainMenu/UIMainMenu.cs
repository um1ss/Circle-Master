using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _UIMainMenu;

    private void Awake()
    {
        Enable();
    }

    private void Enable()
    {
        _UIMainMenu.SetActive(true);
    }

    private void Disable()
    {
        _UIMainMenu.SetActive(false);
    }

    public void GameStart()
    {
        //EventBus.Instance.GameStarted?.Invoke();
        Disable();
    }
}
