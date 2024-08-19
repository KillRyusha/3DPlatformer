using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    [SerializeField] private int _value;
    [SerializeField] private TMP_Text _frontValueText;
    [SerializeField] private TMP_Text _backValueText;
    [SerializeField] private CoinsController _coinsController;

    void Awake()
    {
        _frontValueText.text = _value.ToString();
        _backValueText.text = _value.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            _coinsController.AddCoin(_value);
            Destroy(gameObject);
        }
    }
}
