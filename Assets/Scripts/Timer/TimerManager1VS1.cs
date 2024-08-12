using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TimerManager1VS1 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _uiTimer;
    [SerializeField] private float _time;

    private bool _timerIsRunning;

    public float Seconds => _time;
    public TextMeshProUGUI UITimer => _uiTimer;

    void Awake()
    {
        EventBus1VS1.Instance.GameHasStarted += StartTimer;
        EventBus1VS1.Instance.GameHasReloaded += StartTimer;
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
            EventBus1VS1.Instance.StartParticles?.Invoke();
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

    IEnumerator WaitForHalfSecond()
    {
        // Ждем 0.5 секунды
        yield return new WaitForSeconds(1f);
        EventBus1VS1.Instance.GameIsOver?.Invoke();
    }

    private void OnDestroy()
    {
        EventBus1VS1.Instance.GameHasStarted -= StartTimer;
        EventBus1VS1.Instance.GameHasReloaded -= StartTimer;
    }
}

