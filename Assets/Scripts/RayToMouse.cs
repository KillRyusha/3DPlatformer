using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayToMouse : MonoBehaviour
{

    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private GameObject _gameObject;
    private const int MaxDistance = 400;
    private RaycastHit _hit;
    private Ray _ray;
    private Selectable _selectable;
    void Update()
    {
        _ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(_ray.origin, _ray.direction, out _hit, MaxDistance, _layerMask))
        {
            Debug.DrawRay(_ray.origin, _ray.direction * _hit.distance, Color.red);

            if (_selectable && _hit.transform.GetComponent<Selectable>() != _selectable)
            {
                _selectable.Deselect();
                _selectable = _hit.transform.GetComponent<Selectable>();
                _selectable.Select();
                _gameObject.transform.position = _hit.point;
            }
            else if (_hit.transform.GetComponent<Selectable>())
            {
                _selectable = _hit.transform.GetComponent<Selectable>();
                _selectable.Select();
                _gameObject.transform.position = _hit.point;
            }
        }
        else
        {
            Debug.DrawRay(_ray.origin, _ray.direction * 1000, Color.yellow);
            if (_selectable)
            {
                _selectable.Deselect();
                _selectable = null;
            }
        }
    }
}
