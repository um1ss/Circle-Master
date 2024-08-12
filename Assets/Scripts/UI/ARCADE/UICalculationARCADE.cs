using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YG;

public class UICalculationARCADE : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoresHighPlayer;
    [SerializeField] private TextMeshProUGUI _scoresUser;
    [SerializeField] private TextMeshProUGUI _scoresLowPlayer;
    [SerializeField] private TextMeshProUGUI _scoresVeryLowPlayer;

    [SerializeField] private List<string> _randomNamesOnEn;
    [SerializeField] private List<string> _randomNamesOnRu;
    [SerializeField] private List<string> _randomNamesOnTr;

    private void Awake()
    {
        EventBusARCADE.Instance.GameIsOver += OutputScoresHigh;
        EventBusARCADE.Instance.GameIsOver += OutputScoresPlayer;
        EventBusARCADE.Instance.GameIsOver += OutputScoresLow;
        EventBusARCADE.Instance.GameIsOver += OutputScoresVeryLow;
    }

    private void OutputScoresHigh()
    {
        if (YandexGame.EnvironmentData.language == "en")
        {
            var randomNumber = Random.Range(0, _randomNamesOnEn.Count);
            _scoresHighPlayer.text = $"{_randomNamesOnEn[randomNumber]}:  {PlusPointHighPlayer().ToString()}";
        }
        else if (YandexGame.EnvironmentData.language == "ru")
        {
            var randomNumber = Random.Range(0, _randomNamesOnRu.Count);
            _scoresHighPlayer.text = $"{_randomNamesOnRu[randomNumber]}:  {PlusPointHighPlayer().ToString()}";
        }
        else if (YandexGame.EnvironmentData.language == "tr")
        {
            var randomNumber = Random.Range(0, _randomNamesOnTr.Count);
            _scoresHighPlayer.text = $"{_randomNamesOnTr[randomNumber]}:  {PlusPointHighPlayer().ToString()}";
        }
        else
        {
            var randomNumber = Random.Range(0, _randomNamesOnEn.Count);
            _scoresHighPlayer.text = $"{_randomNamesOnEn[randomNumber]}:  {PlusPointHighPlayer().ToString()}";
        }
    }

    private void OutputScoresPlayer()
    {
        if (YandexGame.EnvironmentData.language == "en")
            _scoresUser.text = $"Scores:  {YandexGame.savesData.record.ToString()}";
        else if (YandexGame.EnvironmentData.language == "ru")
            _scoresUser.text = $"Очки:  {YandexGame.savesData.record.ToString()}";
        else if (YandexGame.EnvironmentData.language == "tr")
            _scoresUser.text = $"Gözlük:  {YandexGame.savesData.record.ToString()}";
        else
            _scoresUser.text = $"Scores:  {YandexGame.savesData.record.ToString()}";
    }

    private void OutputScoresLow()
    {
        if (YandexGame.EnvironmentData.language == "en")
        {
            if (YandexGame.savesData.record <= 3)
            {
                var randomNumber = Random.Range(0, _randomNamesOnEn.Count);
                _scoresLowPlayer.text = $"{_randomNamesOnEn[randomNumber]}:  0";
            }
            else
            {
                var randomNumber = Random.Range(0, _randomNamesOnEn.Count);
                _scoresLowPlayer.text = $"{_randomNamesOnEn[randomNumber]}:  {MinusPointLowPlayer().ToString()}";
            }
        }
        else if (YandexGame.EnvironmentData.language == "ru")
        {
            if (YandexGame.savesData.record <= 3)
            {
                var randomNumber = Random.Range(0, _randomNamesOnRu.Count);
                _scoresLowPlayer.text = $"{_randomNamesOnRu[randomNumber]}:  0";
            }
            else
            {
                var randomNumber = Random.Range(0, _randomNamesOnRu.Count);
                _scoresLowPlayer.text = $"{_randomNamesOnRu[randomNumber]}:  {MinusPointLowPlayer().ToString()}";
            }
        }
        else if (YandexGame.EnvironmentData.language == "tr")
        {
            if (YandexGame.savesData.record <= 3)
            {
                var randomNumber = Random.Range(0, _randomNamesOnTr.Count);
                _scoresLowPlayer.text = $"{_randomNamesOnTr[randomNumber]}:  0";
            }
            else
            {
                var randomNumber = Random.Range(0, _randomNamesOnTr.Count);
                _scoresLowPlayer.text = $"{_randomNamesOnTr[randomNumber]}:  {MinusPointLowPlayer().ToString()}";
            }
        }
        else
        {
            if (YandexGame.savesData.record <= 3)
            {
                var randomNumber = Random.Range(0, _randomNamesOnEn.Count);
                _scoresLowPlayer.text = $"{_randomNamesOnEn[randomNumber]}:  0";
            }
            else
            {
                var randomNumber = Random.Range(0, _randomNamesOnEn.Count);
                _scoresLowPlayer.text = $"{_randomNamesOnEn[randomNumber]}:  {MinusPointLowPlayer().ToString()}";
            }
        }
    }

    private void OutputScoresVeryLow()
    {
        if (YandexGame.EnvironmentData.language == "en")
        {
            if (YandexGame.savesData.record <= 3)
            {
                var randomNumber = Random.Range(0, _randomNamesOnEn.Count);
                _scoresVeryLowPlayer.text = $"{_randomNamesOnEn[randomNumber]}:  0";
            }
            else
            {
                var randomNumber = Random.Range(0, _randomNamesOnEn.Count);
                _scoresVeryLowPlayer.text = $"{_randomNamesOnEn[randomNumber]}:  {MinusPointVeryLowPlayer().ToString()}";
            }
        }
        else if (YandexGame.EnvironmentData.language == "ru")
        {
            if (YandexGame.savesData.record <= 3)
            {
                var randomNumber = Random.Range(0, _randomNamesOnRu.Count);
                _scoresVeryLowPlayer.text = $"{_randomNamesOnRu[randomNumber]}:  0";
            }
            else
            {
                var randomNumber = Random.Range(0, _randomNamesOnRu.Count);
                _scoresVeryLowPlayer.text = $"{_randomNamesOnRu[randomNumber]}:  {MinusPointVeryLowPlayer().ToString()}";
            }
        }
        else if (YandexGame.EnvironmentData.language == "tr")
        {
            if (YandexGame.savesData.record <= 3)
            {
                var randomNumber = Random.Range(0, _randomNamesOnTr.Count);
                _scoresVeryLowPlayer.text = $"{_randomNamesOnTr[randomNumber]}:  0";
            }
            else
            {
                var randomNumber = Random.Range(0, _randomNamesOnTr.Count);
                _scoresVeryLowPlayer.text = $"{_randomNamesOnTr[randomNumber]}:  {MinusPointVeryLowPlayer().ToString()}";
            }
        }
        else
        {
            if (YandexGame.savesData.record <= 3)
            {
                var randomNumber = Random.Range(0, _randomNamesOnEn.Count);
                _scoresVeryLowPlayer.text = $"{_randomNamesOnEn[randomNumber]}:  0";
            }
            else
            {
                var randomNumber = Random.Range(0, _randomNamesOnEn.Count);
                _scoresVeryLowPlayer.text = $"{_randomNamesOnEn[randomNumber]}:  {MinusPointVeryLowPlayer().ToString()}";
            }
        }
    }

    private int PlusPointHighPlayer()
    {
        return YandexGame.savesData.record + Random.Range(1, 5);
    }

    private int MinusPointLowPlayer()
    {
        return YandexGame.savesData.record - Random.Range(1, 2);
    }

    private int MinusPointVeryLowPlayer()
    {
        return YandexGame.savesData.record - Random.Range(2, 4);
    }

    private void OnDestroy()
    {
        EventBusARCADE.Instance.GameIsOver -= OutputScoresHigh;
        EventBusARCADE.Instance.GameIsOver -= OutputScoresPlayer;
        EventBusARCADE.Instance.GameIsOver -= OutputScoresLow;
        EventBusARCADE.Instance.GameIsOver -= OutputScoresVeryLow;
    }
}
