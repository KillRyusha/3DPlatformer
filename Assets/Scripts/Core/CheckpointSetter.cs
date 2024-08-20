using UnityEngine;

public class CheckpointSetter : MonoBehaviour
{
    [SerializeField] private CheckpointController _controller;
    [SerializeField] private int _index;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>()) 
        {
            _controller.SetNewCheckpoint(_index);
        }
    }
}