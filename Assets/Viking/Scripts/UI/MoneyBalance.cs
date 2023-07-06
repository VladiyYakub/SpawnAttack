using TMPro;
using UnityEngine;

public class MoneyBalance : MonoBehaviour
{
    [SerializeField] private TMP_Text _money;
    [SerializeField] private Player _paleyr;

    private void OnEnable()
    {
        _money.text = _paleyr.Money.ToString();
        _paleyr.MoneyCganged += OnMoneyChanged;
    }

    private void OnDisable()
    {
        _paleyr.MoneyCganged -= OnMoneyChanged;
    }

    private void OnMoneyChanged(int money)
    {
        _money.text = money.ToString();
    } 
}

