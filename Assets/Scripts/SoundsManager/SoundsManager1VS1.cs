using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManager1VS1 : MonoBehaviour
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
        EventBus1VS1.Instance.GameHasReloaded += PlayLoopSoundBackground;
        EventBus1VS1.Instance.GameIsOver += StopSoundBackground;
        EventBus1VS1.Instance.GameIsOver += PlayOneShotGameIsOver;
        EventBus1VS1.Instance.UserOneEarnedPoint += PlayOneShotUserGotHit;
        EventBus1VS1.Instance.UserTwoEarnedPoint += PlayOneShotUserGotHit;
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

    private void OnDestroy()
    {
        EventBus1VS1.Instance.GameHasReloaded -= PlayLoopSoundBackground;
        EventBus1VS1.Instance.GameIsOver -= StopSoundBackground;
        EventBus1VS1.Instance.GameIsOver -= PlayOneShotGameIsOver;
        EventBus1VS1.Instance.UserOneEarnedPoint -= PlayOneShotUserGotHit;
        EventBus1VS1.Instance.UserTwoEarnedPoint -= PlayOneShotUserGotHit;
    }
}
