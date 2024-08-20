using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{
    [SerializeField] private int _sceneNumber;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.GetComponent<PlayerMovement>())
        {
            if(_sceneNumber > -1 && _sceneNumber < SceneManager.sceneCount)
                SceneManager.LoadScene(_sceneNumber);
        }
    }
}
