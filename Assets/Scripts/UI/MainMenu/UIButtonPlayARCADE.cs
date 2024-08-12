using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class UIButtonPlayARCADE : MonoBehaviour
{
    public void LoadSceneByName(string sceneName)
    {
        YandexGame.SaveProgress();
        SceneManager.LoadScene(sceneName);
    }
}
