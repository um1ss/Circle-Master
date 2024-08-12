using System;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class UIVolume : MonoBehaviour
{
    [SerializeField] private GameObject _volumeOn;
    [SerializeField] private GameObject _volumeMut;

    private void Update()
    {
        if (YandexGame.savesData.VolumeIsActive)
        {
            _volumeMut.SetActive(false);
            _volumeOn.SetActive(true);
            AudioListener.volume = 1f;
        }
        else
        {
            _volumeOn.SetActive(false);
            _volumeMut.SetActive(true);
            AudioListener.volume = 0f;
        }
    }

    public void ChangeVolume()
    {
        if (YandexGame.savesData.VolumeIsActive)
        {
            YandexGame.savesData.VolumeIsActive = false;
        }
        else if (!YandexGame.savesData.VolumeIsActive)
        {
            YandexGame.savesData.VolumeIsActive = true;
        }
    }
}