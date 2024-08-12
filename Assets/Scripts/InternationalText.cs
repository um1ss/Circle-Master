using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InternationalText : MonoBehaviour
{
    [SerializeField] string _en;
    [SerializeField] string _ru;
    [SerializeField] string _tr;

    private void Start()
    {
        if (Language.Instance.CurrentLanguage == "en")
        {
            GetComponent<TextMeshProUGUI>().text = _en;
        }
        else if (Language.Instance.CurrentLanguage == "ru")
        {
            GetComponent<TextMeshProUGUI>().text = _ru;
        }
        else if (Language.Instance.CurrentLanguage == "tr")
        {
            GetComponent<TextMeshProUGUI>().text = _tr;
        }
        else
        {
            GetComponent<TextMeshProUGUI>().text = _en;
        }
    }
}
