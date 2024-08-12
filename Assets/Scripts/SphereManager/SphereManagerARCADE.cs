using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManagerARCADE : MonoBehaviour
{
    [SerializeField] private GameObject _prefabSphere;
    //[SerializeField] private List<Vector3> _listPosition;

    private GameObject _instanceSphere;
    //private int currentPositionIndex = 0;

    private void Awake()
    {
        EventBusARCADE.Instance.GameHasStarted += CreateInstance;
        EventBusARCADE.Instance.GameContinued += CreateInstance;
        EventBusARCADE.Instance.GameHasReloaded += CreateInstance;
        EventBusARCADE.Instance.UserEarnedPoint += ChangePosition;
        EventBusARCADE.Instance.GameIsOver += DestructionInstance;
    }

    private void ChangePosition()
    {
        _instanceSphere.transform.position = RandomNumbersGenerator();
    }

    private Vector3 RandomNumbersGenerator()
    {
        return new Vector3(Random.Range(-3.0f, 3.0f), Random.Range(-2.0f, 3.0f), 7);
    }

    private void CreateInstance()
    {
        _instanceSphere = Instantiate(_prefabSphere);
    }

    private void DestructionInstance()
    {
        Destroy(_instanceSphere);
    }

    private void OnDestroy()
    {
        EventBusARCADE.Instance.GameHasStarted -= CreateInstance;
        EventBusARCADE.Instance.GameContinued -= CreateInstance;
        EventBusARCADE.Instance.GameHasReloaded -= CreateInstance;
        EventBusARCADE.Instance.UserEarnedPoint -= ChangePosition;
        EventBusARCADE.Instance.GameIsOver -= DestructionInstance;
    }
}
