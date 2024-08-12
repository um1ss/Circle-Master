using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayerCheckingPass : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Sphere")
        {
            EventBus1VS1.Instance.UserTwoEarnedPoint?.Invoke();
            Debug.Log("Игрок 2 Забил Гол");
        }
    }
}
