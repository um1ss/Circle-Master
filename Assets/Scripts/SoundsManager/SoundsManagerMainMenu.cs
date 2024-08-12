using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManagerMainMenu : MonoBehaviour
{
    [SerializeField] private AudioClip _clickButton;
    [SerializeField] private AudioClip _backgroundMusic;

    [SerializeField] private AudioSource _audioSourceButton;
    [SerializeField] private AudioSource _audioSourceManager;

    private void Start()
    {
        _audioSourceButton.clip = _clickButton;
        _audioSourceManager.clip = _backgroundMusic;
        PlayLoopSound();
    }

    public void PlayOneShot()
    {
        _audioSourceButton.Play();
    }

    private void PlayLoopSound()
    {
        _audioSourceManager.loop = true;
        _audioSourceManager.Play();
    }

    public void PauseMusic()
    {
        _audioSourceManager.Pause();
    }

    public void ContinueMusic()
    {
        _audioSourceManager.UnPause();
    }
}
