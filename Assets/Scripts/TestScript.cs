using UnityEngine;

public class TestScript : MonoBehaviour
{
    private const string FROGS_VALUE = "Frogs";
    [SerializeField] private int _number;

    private void Awake()
    {
        _number = PlayerPrefs.GetInt(FROGS_VALUE, 3);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt(FROGS_VALUE, _number);
    }

}
