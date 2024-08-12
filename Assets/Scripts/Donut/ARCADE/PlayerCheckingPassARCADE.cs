using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckingPassARCADE : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Sphere")
        {
            EventBusARCADE.Instance.UserEarnedPoint?.Invoke();
            Debug.Log("Игрок 1 Забил Гол");
        }
    }
}
