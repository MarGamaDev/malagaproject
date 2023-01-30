using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Header("Refrences.")]
    [SerializeField] private TextMeshProUGUI _currencyDisplay;
    private CurrencyManager _currencyManager;

    /// <summary>
    /// Gets the Currency manager.
    /// </summary>
    private void Awake()
    {
        if (TryGetComponent(out CurrencyManager currencyMG))
        {
            _currencyManager = currencyMG;
        }
        else
        {
            _currencyManager = FindObjectOfType<CurrencyManager>();
        }
    }

    private void Start()
    {
        UpdateCurrencyValue();
    }

    /// <summary>
    /// Updates the Display to the current Currency.
    /// </summary>
    public void UpdateCurrencyValue()
    {
        _currencyDisplay.text = _currencyManager.Currency.ToString(",");
    }
}
