using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Header("Refrences.")]
    [SerializeField] private TextMeshProUGUI _currencyDisplay;

    private void Start()
    {
        UpdateCurrencyValue();
    }

    /// <summary>
    /// Updates the Display to the current Currency.
    /// </summary>
    public void UpdateCurrencyValue()
    {
        _currencyDisplay.text = CurrencyManager.Instance.Currency.ToString();
    }
}
