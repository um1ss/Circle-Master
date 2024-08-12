using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class UIButtonPlay1VS1 : MonoBehaviour
{
    public void LoadSceneByName(string sceneName)
    {
        YandexGame.SaveProgress();
        SceneManager.LoadScene(sceneName);
    }
}
