using UnityEngine;

public class CheckpointView : MonoBehaviour
{
    [SerializeField] private Transform[] _checkpoints;
    public Vector3 GetCheckpointPosition(int index)
    {
        return _checkpoints[index].position;
    }
}
