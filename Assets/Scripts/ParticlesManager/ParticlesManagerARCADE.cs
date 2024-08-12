using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesManagerARCADE : MonoBehaviour
{
    [SerializeField] private ParticleSystem _wow;
    [SerializeField] private ParticleSystem _itemSparklePurple;

    private void Awake()
    {
        EventBusARCADE.Instance.UserEarnedPoint += PlayOneShotWow;
        EventBusARCADE.Instance.StartParticles += PlayOneShotItemSparklePurple;
    }

    private void PlayOneShotWow()
    {
        ParticleSystem particleSystemInstance = Instantiate(_wow, RandomGeneratorVector3Wow(), Quaternion.identity);
        Destroy(particleSystemInstance.gameObject, particleSystemInstance.main.duration);
    }

    private void PlayOneShotItemSparklePurple()
    {
        ParticleSystem particleSystemInstance = Instantiate(_itemSparklePurple, new Vector3(-2, -3, 4), Quaternion.Euler(-90, 0, 0));
        ParticleSystem particleSystemInstance2 = Instantiate(_itemSparklePurple, new Vector3(2, -3, 4), Quaternion.Euler(-90, 0, 0));
        Destroy(particleSystemInstance.gameObject, particleSystemInstance.main.duration);
        Destroy(particleSystemInstance2.gameObject, particleSystemInstance2.main.duration);
    }

    private Vector3 RandomGeneratorVector3Wow()
    {
        return new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-2.0f, 2.0f), 0);
    }

    private void OnDestroy()
    {
        EventBusARCADE.Instance.UserEarnedPoint -= PlayOneShotWow;
        EventBusARCADE.Instance.StartParticles -= PlayOneShotItemSparklePurple;
    }
}
