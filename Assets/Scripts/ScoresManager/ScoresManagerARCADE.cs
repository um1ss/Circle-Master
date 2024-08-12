using TMPro;
using UnityEngine;
using YG;

public class ScoresManagerARCADE : MonoBehaviour
{
    [SerializeField] private UICanvasARCADE _uiCanvasARCADE;

    [SerializeField] private TextMeshProUGUI _uiScoresPlayer;

    private int _scoresPlayer;

    public static int BestScoresPlayer;

    public TextMeshProUGUI UIScoresPlayer => _uiScoresPlayer;
    public int ScoresPlayer => _scoresPlayer;

    private void Awake()
    {
        EventBusARCADE.Instance.GameHasStarted += ResetScores;
        EventBusARCADE.Instance.GameHasReloaded += ResetScores;
        EventBusARCADE.Instance.UserEarnedPoint += UserEarnedPoint;
        EventBusARCADE.Instance.GameIsOver += CheckingOpenSkin;
    }

    private void Start()
    {
        _scoresPlayer = 0;
    }

    private void Update()
    {
        ConvertToString();
        if (_scoresPlayer > BestScoresPlayer)
        {
            BestScoresPlayer = _scoresPlayer;
        }
    }

    //Метод добавляет очко
    private void UserEarnedPoint()
    {
        _scoresPlayer++;
    }

    //Метод конвертирует из int в string
    private void ConvertToString()
    {
        _uiScoresPlayer.text = _scoresPlayer.ToString();
    }

    private void ResetScores()
    {
        _scoresPlayer = 0;
    }

    private void CheckingOpenSkin()
    {
        if (BestScoresPlayer >= 5 && !YandexGame.savesData.SkinIsOpenMINECRAFT ||
            BestScoresPlayer >= 10 && !YandexGame.savesData.SkinIsOpenMARIO ||
            BestScoresPlayer >= 15 && !YandexGame.savesData.SkinIsOpenKRENDEL ||
            BestScoresPlayer >= 20 && !YandexGame.savesData.SkinIsOpenINSIDE ||
            BestScoresPlayer >= 25 && !YandexGame.savesData.SkinIsOpenDONUT ||
            BestScoresPlayer >= 30 && !YandexGame.savesData.SkinIsOpenCANDY ||
            BestScoresPlayer >= 40 && !YandexGame.savesData.SkinIsOpenBEACH ||
            BestScoresPlayer >= 45 && !YandexGame.savesData.SkinIsOpenBANANA ||
            BestScoresPlayer >= 50 && !YandexGame.savesData.SkinIsOpenBADTRIP ||
            BestScoresPlayer >= 55 && !YandexGame.savesData.SkinIsOpenWHEEL
            )
        {
            _uiCanvasARCADE.EnableButtonNewSkin();
        }
        else
        {
            _uiCanvasARCADE.DisableButtonNewSkin();
        }
    }

    private void OnDestroy()
    {
        EventBusARCADE.Instance.GameHasStarted -= ResetScores;
        EventBusARCADE.Instance.GameHasReloaded -= ResetScores;
        EventBusARCADE.Instance.UserEarnedPoint -= UserEarnedPoint;
        EventBusARCADE.Instance.GameIsOver -= CheckingOpenSkin;
    }
}
