using TMPro;
using UnityEngine;

public class ScoresManager1VS1 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _uiScoresPlayer;
    [SerializeField] private TextMeshProUGUI _uiScoresPlayer2;

    public TextMeshProUGUI UIScoresPlayer => _uiScoresPlayer;
    public TextMeshProUGUI UIScoresPlayer2 => _uiScoresPlayer2;

    private int _scoresPlayer;
    private int _scoresPlayer2;

    public int ScorePlayer => _scoresPlayer;
    public int ScorePlayer2 => _scoresPlayer2;

    private void Awake()
    {
        EventBus1VS1.Instance.GameHasStarted += ResetScores;
        EventBus1VS1.Instance.GameHasReloaded += ResetScores;
        EventBus1VS1.Instance.UserOneEarnedPoint += UserOneEarnedPoint;
        EventBus1VS1.Instance.UserTwoEarnedPoint += UserTwoEarnedPoint;
    }

    private void Start()
    {
        _scoresPlayer = 0;
        _scoresPlayer2 = 0;
    }

    private void Update()
    {
        ConvertToString();
    }

    //Метод добавляет очко
    private void UserOneEarnedPoint()
    {
        _scoresPlayer++;
    }

    private void UserTwoEarnedPoint()
    {
        _scoresPlayer2++;
    }

    //Метод конвертирует из int в string
    private void ConvertToString()
    {
        _uiScoresPlayer.text = _scoresPlayer.ToString();
        _uiScoresPlayer2.text = _scoresPlayer2.ToString();
    }

    private void ResetScores()
    {
        _scoresPlayer = 0;
        _scoresPlayer2 = 0;
    }

    private void OnDestroy()
    {
        EventBus1VS1.Instance.GameHasStarted -= ResetScores;
        EventBus1VS1.Instance.GameHasReloaded -= ResetScores;
        EventBus1VS1.Instance.UserOneEarnedPoint -= UserOneEarnedPoint;
        EventBus1VS1.Instance.UserTwoEarnedPoint -= UserTwoEarnedPoint;
    }
}
