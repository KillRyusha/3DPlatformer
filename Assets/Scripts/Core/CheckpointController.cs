using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    [SerializeField] private CheckpointView _view;
    private CheckpointModel _model = new CheckpointModel();

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.transform.position = _view.GetCheckpointPosition(_model.Index);
        }
    }

    public void SetNewCheckpoint(int index)
    {
        _model.Index = index;
    }

}
