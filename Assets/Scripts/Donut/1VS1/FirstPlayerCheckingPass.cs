using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPlayerCheckingPass : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Sphere")
        {
            EventBus1VS1.Instance.UserOneEarnedPoint?.Invoke();
            Debug.Log("Игрок 1 Забил Гол");
        }
    }
}
