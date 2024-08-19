using TMPro;
using UnityEngine;

public class CoinsView : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinsText;
    [SerializeField] private TMP_Text _maxCoins;
    public void ChangeText(int coins)
    {
        _coinsText.text = "Coins: " + coins;
    }

    public void SetMaxCoins(int maxCoins)
    {
        _maxCoins.text = "Max coins: " + maxCoins;
    }
}