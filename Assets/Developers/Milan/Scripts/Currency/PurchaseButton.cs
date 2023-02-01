using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseButton : MonoBehaviour
{
    private float _moneyToAdd;

    public void MoneyToAdd(float addMoney)
    {
        _moneyToAdd = addMoney;
    }

    public void AcceptPurchase()
    {
        CurrencyManager.Instance.ModifyCurrency(_moneyToAdd);
    }
}
