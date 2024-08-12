using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UICalculation : MonoBehaviour
{
    [SerializeField] private ScoresManager1VS1 _scoresPlayers;

    [SerializeField] private TextMeshProUGUI _uiPlayerWin;
    [SerializeField] private TextMeshProUGUI _uiPlayerLose;
    [SerializeField] private TextMeshProUGUI _uiResultText;

    [SerializeField] private GameObject _backgroundPlayerWin;

    private void Awake()
    {
        EventBus1VS1.Instance.GameIsOver += OutputUserWin;
        EventBus1VS1.Instance.GameIsOver += OutputUser2Win;
        EventBus1VS1.Instance.GameIsOver += OutputDraw;
    }

    private void OutputUserWin()
    {
        if (Language.Instance.CurrentLanguage == "en")
        {
            if (_scoresPlayers.ScorePlayer > _scoresPlayers.ScorePlayer2)
            {
                _uiPlayerWin.text = $"Player 1:  {_scoresPlayers.ScorePlayer.ToString()}";
                _uiPlayerLose.text = $"Player 2:  {_scoresPlayers.ScorePlayer2.ToString()}";
            }
        }
        else if (Language.Instance.CurrentLanguage == "ru")
        {
            if (_scoresPlayers.ScorePlayer > _scoresPlayers.ScorePlayer2)
            {
                _uiPlayerWin.text = $"Игрок 1:  {_scoresPlayers.ScorePlayer.ToString()}";
                _uiPlayerLose.text = $"Игрок 2:  {_scoresPlayers.ScorePlayer2.ToString()}";
            }
        }
        else if (Language.Instance.CurrentLanguage == "tr")
        {
            if (_scoresPlayers.ScorePlayer > _scoresPlayers.ScorePlayer2)
            {
                _uiPlayerWin.text = $"Oyuncu 1:  {_scoresPlayers.ScorePlayer.ToString()}";
                _uiPlayerLose.text = $"Oyuncu 2:  {_scoresPlayers.ScorePlayer2.ToString()}";
            }
        }
        else
        {
            if (_scoresPlayers.ScorePlayer > _scoresPlayers.ScorePlayer2)
            {
                _uiPlayerWin.text = $"Player 1:  {_scoresPlayers.ScorePlayer.ToString()}";
                _uiPlayerLose.text = $"Player 2:  {_scoresPlayers.ScorePlayer2.ToString()}";
            }
        }
    }

    private void OutputUser2Win()
    {
        if (Language.Instance.CurrentLanguage == "en")
        {
            if (_scoresPlayers.ScorePlayer2 > _scoresPlayers.ScorePlayer)
            {
                _uiPlayerWin.text = $"Player 2:  {_scoresPlayers.ScorePlayer2.ToString()}";
                _uiPlayerLose.text = $"Player 1:  {_scoresPlayers.ScorePlayer.ToString()}";
            }
        }
        else if (Language.Instance.CurrentLanguage == "ru")
        {
            if (_scoresPlayers.ScorePlayer2 > _scoresPlayers.ScorePlayer)
            {
                _uiPlayerWin.text = $"Игрок 2:  {_scoresPlayers.ScorePlayer2.ToString()}";
                _uiPlayerLose.text = $"Игрок 1:  {_scoresPlayers.ScorePlayer.ToString()}";
            }
        }
        else if (Language.Instance.CurrentLanguage == "tr")
        {
            if (_scoresPlayers.ScorePlayer2 > _scoresPlayers.ScorePlayer)
            {
                _uiPlayerWin.text = $"Oyuncu 2:  {_scoresPlayers.ScorePlayer2.ToString()}";
                _uiPlayerLose.text = $"Oyuncu 1:  {_scoresPlayers.ScorePlayer.ToString()}";
            }
        }
        else
        {
            if (_scoresPlayers.ScorePlayer2 > _scoresPlayers.ScorePlayer)
            {
                _uiPlayerWin.text = $"Player 2:  {_scoresPlayers.ScorePlayer2.ToString()}";
                _uiPlayerLose.text = $"Player 1:  {_scoresPlayers.ScorePlayer.ToString()}";
            }
        }
    }

    private void OutputDraw()
    {
        if (Language.Instance.CurrentLanguage == "en")
        {
            if (_scoresPlayers.ScorePlayer == _scoresPlayers.ScorePlayer2)
            {
                _backgroundPlayerWin.SetActive(false);
                _uiResultText.text = "DRAW";
                _uiPlayerWin.text = $"Player 1:  {_scoresPlayers.ScorePlayer.ToString()}";
                _uiPlayerLose.text = $"Player 2:  {_scoresPlayers.ScorePlayer2.ToString()}";
            }
        }
        else if (Language.Instance.CurrentLanguage == "ru")
        {
            if (_scoresPlayers.ScorePlayer == _scoresPlayers.ScorePlayer2)
            {
                _backgroundPlayerWin.SetActive(false);
                _uiResultText.text = "НИЧЬЯ";
                _uiPlayerWin.text = $"Игрок 1:  {_scoresPlayers.ScorePlayer.ToString()}";
                _uiPlayerLose.text = $"Игрок 2:  {_scoresPlayers.ScorePlayer2.ToString()}";
            }
        }
        else if (Language.Instance.CurrentLanguage == "tr")
        {
            if (_scoresPlayers.ScorePlayer == _scoresPlayers.ScorePlayer2)
            {
                _backgroundPlayerWin.SetActive(false);
                _uiResultText.text = "BERABERLİK";
                _uiPlayerWin.text = $"Oyuncu 1:  {_scoresPlayers.ScorePlayer.ToString()}";
                _uiPlayerLose.text = $"Oyuncu 2:  {_scoresPlayers.ScorePlayer2.ToString()}";
            }
        }
        else
        {
            if (_scoresPlayers.ScorePlayer == _scoresPlayers.ScorePlayer2)
            {
                _backgroundPlayerWin.SetActive(false);
                _uiResultText.text = "DRAW";
                _uiPlayerWin.text = $"Player 1:  {_scoresPlayers.ScorePlayer.ToString()}";
                _uiPlayerLose.text = $"Player 2:  {_scoresPlayers.ScorePlayer2.ToString()}";
            }
        }
    }

    private void OnDestroy()
    {
        EventBus1VS1.Instance.GameIsOver -= OutputUserWin;
        EventBus1VS1.Instance.GameIsOver -= OutputUser2Win;
        EventBus1VS1.Instance.GameIsOver -= OutputDraw;
    }
}
