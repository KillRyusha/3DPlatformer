using UnityEngine;

public class CoinsSaveService
{
    private CoinsModel _coinsModel;
    private int _baseCoins;

    public CoinsSaveService(CoinsModel coinsModel)
    {
        _coinsModel = coinsModel;
        _baseCoins = _coinsModel.MaxCoins;
    }

    public void UpdateCoins()
    {
        if (_baseCoins < _coinsModel.Coins)
            PlayerPrefs.SetInt(GameStatsConsts.COINS, _coinsModel.Coins);
    }

}
