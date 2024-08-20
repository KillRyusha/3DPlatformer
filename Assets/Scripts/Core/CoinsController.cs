using UnityEngine;

public class CoinsController : MonoBehaviour
{
    [SerializeField] private CoinsView _coinsView;
    private CoinsSaveService _coinsSaveService;
    private CoinsModel _coinsModel;

    private void Awake()
    {
        _coinsModel = new CoinsModel();
        _coinsSaveService = new CoinsSaveService(_coinsModel);
        _coinsView.SetMaxCoins(_coinsModel.MaxCoins);
    }

    public void AddCoin(int coin)
    {
        _coinsModel.AddCoins(coin);
        _coinsView.ChangeText(_coinsModel.Coins);
    }
    private void OnDisable()
    {
        _coinsSaveService.UpdateCoins();
    }
}
