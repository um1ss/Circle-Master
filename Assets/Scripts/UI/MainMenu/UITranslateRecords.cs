using TMPro;
using UnityEngine;
using YG;

public class UITranslateRecords : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _record;

    private void Start()
    {
        _record.text = YandexGame.savesData.record.ToString();
    }
}
