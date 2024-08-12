using System.Collections;
using TMPro;
using UnityEngine;

public class TimerManagerARCADE : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _uiTimer;
    [SerializeField] private float _time;
    
    private bool _timerIsRunning;

    public float Seconds => _time;
    public TextMeshProUGUI UITimer => _uiTimer;

    void Awake()
    {
        EventBusARCADE.Instance.GameHasStarted += StartTimer;
        EventBusARCADE.Instance.GameHasReloaded += StartTimer;
        EventBusARCADE.Instance.GameContinued += AddedTime;
    }
    void Update()
    {
        if (_timerIsRunning)
        {
            UpdateTimer();
        }
    }

    //Отсчитываем время
    private void UpdateTimer()
    {
        _time -= Time.deltaTime;

        if (_time <= 0f)
        {
            _time = 0f;
            _timerIsRunning = false;
            EventBusARCADE.Instance.StartParticles?.Invoke();
            StartCoroutine(WaitForHalfSecond());
        }

        UpdateUIText();
    }

    //Обновляет UI Interface
    private void UpdateUIText()
    {
        int minutes = Mathf.FloorToInt(_time / 60f);
        int seconds = Mathf.FloorToInt(_time % 60f);

        _uiTimer.text = $"{minutes:00}:{seconds:00}";
    }

    //Сбрасывает время раунда
    private void StartTimer()
    {
        _time = 60f;
        _timerIsRunning = true;
    }

    private void AddedTime()
    {
        _time = 10f;
        _timerIsRunning = true;
    }

    IEnumerator WaitForHalfSecond()
    {
        // Ждем 0.5 секунды
        yield return new WaitForSeconds(1f);
        EventBusARCADE.Instance.GameIsOver?.Invoke();
    }

    private void OnDestroy()
    {
        EventBusARCADE.Instance.GameHasStarted -= StartTimer;
        EventBusARCADE.Instance.GameHasReloaded -= StartTimer;
        EventBusARCADE.Instance.GameContinued -= AddedTime;
    }
}

