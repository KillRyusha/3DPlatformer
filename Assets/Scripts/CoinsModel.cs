using UnityEngine;

public class CoinsModel
{
    private int _coins;
    private int _maxCoins;
    public int Coins => _coins;
    public int MaxCoins => _maxCoins;
    public CoinsModel()
    {
        _maxCoins = PlayerPrefs.GetInt(GameStatsConsts.COINS, 0);
    }
    public void AddCoins(int coins)
    {
        _coins += coins;
    }
}
