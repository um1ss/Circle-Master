using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager1VS1 : MonoBehaviour
{
    [SerializeField] private GameObject _prefabSphere;

    private GameObject _instanceSphere;

    private void Awake()
    {
        EventBus1VS1.Instance.GameHasStarted += CreateInstance;
        EventBus1VS1.Instance.GameIsOver += DestructionInstance;
    }

    private void DestructionInstance()
    {
        Destroy(_instanceSphere);
    }

    private void CreateInstance()
    {
        _instanceSphere = Instantiate(_prefabSphere);
    }

    private void OnDestroy()
    {
        EventBus1VS1.Instance.GameHasStarted -= CreateInstance;
        EventBus1VS1.Instance.GameIsOver -= DestructionInstance;
    }
}
