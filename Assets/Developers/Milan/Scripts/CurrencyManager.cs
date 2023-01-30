using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyManager : MonoBehaviour
{
    public float Currency;

    [Header("Refrences.")]
    public static CurrencyManager Instance;
    private UIManager _uiManager;

    private void Awake()
    {
        if (Instance != this && Instance != null)
        {
            Object.Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            Instance = this;
        }
    }

    private void Start()
    {
        if (TryGetComponent(out UIManager uiMG))
        {
            _uiManager = uiMG;
        }
        else
        {
            _uiManager = FindObjectOfType<UIManager>();
        }
    }

    public void ModifyCurrency(float addedCurrency)
    {
        Currency += addedCurrency;
        _uiManager.UpdateCurrencyValue();
    }
}
