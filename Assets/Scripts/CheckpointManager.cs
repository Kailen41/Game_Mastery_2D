using System.Linq;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    private Checkpoint[] _checkpoints;

    void Start()
    {
        _checkpoints = GetComponentsInChildren<Checkpoint>();
    }

    public Checkpoint GetLastCheckPointThatWasPassed()
    {
        return _checkpoints.LastOrDefault(t => t.Passed);
    }
}
