using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyCount : MonoBehaviour
{
    [SerializeField] private bool UpdateUI;
    [SerializeField]private TextMeshProUGUI MoneyDisplay;
    // Update is called once per frame
    void Update()
    {
        if (UpdateUI)
        {
            MoneyDisplay.text = $"$ {PlayerPrefs.GetFloat("Wallet").ToString()}";
        }
    }
}
