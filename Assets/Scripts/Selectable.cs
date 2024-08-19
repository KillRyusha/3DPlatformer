using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable : MonoBehaviour
{
    public void Select()
    {
        transform.GetComponent<Renderer>().material.color = Color.white;
    }

    public void Deselect()
    {
        transform.GetComponent<Renderer>().material.color = Color.clear;
    }
}
