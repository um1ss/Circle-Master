using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class UIButtonExit : MonoBehaviour
{
    public void LoadSceneByName(string sceneName)
    {
        YandexGame.SaveProgress();
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }

    public void LoadSceneByNameToSkinSelect(string sceneName)
    {
        YandexGame.SaveProgress();
        Time.timeScale = 1f;
        var toSkinSelect = true;
        UIButtonEnterToTableSkins._fromARCADEScene = toSkinSelect;
        SceneManager.LoadScene(sceneName);
    }
}
