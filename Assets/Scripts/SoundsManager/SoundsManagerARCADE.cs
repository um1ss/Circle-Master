using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManagerARCADE : MonoBehaviour
{
    [SerializeField] private AudioClip _userGotHit;
    [SerializeField] private AudioClip _clickButton;
    [SerializeField] private AudioClip _backgroundMusic;
    [SerializeField] private AudioClip _gameIsOver;

    [SerializeField] private AudioSource _audioSourcePlayer;
    [SerializeField] private AudioSource _audioSourceButton;
    [SerializeField] private AudioSource _audioSourceManager;
    [SerializeField] private AudioSource _audioSourceGameIsOver;

    private void Awake()
    {
        EventBusARCADE.Instance.GameContinued += PlayLoopSoundBackground;
        EventBusARCADE.Instance.GameHasReloaded += PlayLoopSoundBackground;
        EventBusARCADE.Instance.GameIsOver += StopSoundBackground;
        EventBusARCADE.Instance.GameIsOver += PlayOneShotGameIsOver;
        EventBusARCADE.Instance.UserEarnedPoint += PlayOneShotUserGotHit;
    }

    private void Start()
    {
        _audioSourcePlayer.clip = _userGotHit;
        _audioSourceButton.clip = _clickButton;
        _audioSourceManager.clip = _backgroundMusic;
        _audioSourceGameIsOver.clip = _gameIsOver;

        PlayLoopSoundBackground();
    }

    public void PlayOneShotButton()
    {
        _audioSourceButton.Play();
    }

    private void PlayOneShotUserGotHit()
    {
        _audioSourcePlayer.Play();
    }

    private void PlayLoopSoundBackground()
    {
        _audioSourceManager.loop = true;
        _audioSourceManager.Play();
    }

    private void StopSoundBackground()
    {
        _audioSourceManager.Stop();
    }

    private void PlayOneShotGameIsOver()
    {
        _audioSourceGameIsOver.Play();
    }
    
    public void PauseMusic()
    {
        _audioSourceManager.Pause();
    }

    public void ContinueMusic()
    {
        _audioSourceManager.UnPause();
    }

    private void OnDestroy()
    {
        EventBusARCADE.Instance.GameContinued -= PlayLoopSoundBackground;
        EventBusARCADE.Instance.GameHasReloaded -= PlayLoopSoundBackground;
        EventBusARCADE.Instance.GameIsOver -= StopSoundBackground;
        EventBusARCADE.Instance.GameIsOver -= PlayOneShotGameIsOver;
        EventBusARCADE.Instance.UserEarnedPoint -= PlayOneShotUserGotHit;
    }
}
