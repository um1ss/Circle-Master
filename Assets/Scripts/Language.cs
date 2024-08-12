using UnityEngine;
using YG;

public class Language : MonoBehaviour
{
    public string CurrentLanguage;

    public static Language Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            transform.parent = null;
            DontDestroyOnLoad(gameObject);
            Instance = this;

            CurrentLanguage = YandexGame.EnvironmentData.language;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
