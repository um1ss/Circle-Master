using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.LightAnchor;

public class GameManager1VS1 : MonoBehaviour
{
    [SerializeField] private GameObject _prefabSphere;
    [SerializeField] private GameObject _prefabDonut;
    [SerializeField] private GameObject _prefabDonut2;

    private GameObject _instanceSphere;
    private GameObject _instanceDonut;
    private GameObject _instanceDonut2;

    private void Awake()
    {
        EventBus1VS1.Instance.GameHasStarted += CreateInstances;
        EventBus1VS1.Instance.GameIsOver += DestructionInstances;
        EventBus1VS1.Instance.GameHasReloaded += CreateInstances;
    }

    private void Start()
    {
        EventBus1VS1.Instance.GameHasStarted?.Invoke();
    }

    private void CreateInstances()
    {
        _instanceSphere = Instantiate(_prefabSphere);
        _instanceDonut = Instantiate(_prefabDonut);
        _instanceDonut2 = Instantiate(_prefabDonut2);
    }

    private void DestructionInstances()
    {
        Destroy(_instanceSphere);
        Destroy(_instanceDonut);
        Destroy(_instanceDonut2);
    }

    private void OnDestroy()
    {
        EventBus1VS1.Instance.GameHasStarted -= CreateInstances;
        EventBus1VS1.Instance.GameIsOver -= DestructionInstances;
        EventBus1VS1.Instance.GameHasReloaded -= CreateInstances;
    }
}
