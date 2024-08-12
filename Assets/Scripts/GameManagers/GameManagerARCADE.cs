using UnityEngine;

public class GameManagerARCADE : MonoBehaviour
{
    [SerializeField] private GameObject _prefabDonut;

    private GameObject _instanceDonut;

    private void Awake()
    {
        EventBusARCADE.Instance.GameHasStarted += CreateInstances;
        EventBusARCADE.Instance.GameContinued += CreateInstances;
        EventBusARCADE.Instance.GameHasReloaded += CreateInstances;
        EventBusARCADE.Instance.GameIsOver += DestructionInstances;
    }

    private void Start()
    {
        EventBusARCADE.Instance.GameHasStarted?.Invoke();
    }

    private void CreateInstances()
    {
        _instanceDonut = Instantiate(_prefabDonut);
    }

    private void DestructionInstances()
    {
        Destroy(_instanceDonut);
    }

    private void OnDestroy()
    {
        EventBusARCADE.Instance.GameHasStarted -= CreateInstances;
        EventBusARCADE.Instance.GameContinued -= CreateInstances;
        EventBusARCADE.Instance.GameHasReloaded -= CreateInstances;
        EventBusARCADE.Instance.GameIsOver -= DestructionInstances;
    }
}
