using UnityEngine;

public class TriggerZoneB : MonoBehaviour
{
    public TriggerSequenceManager manager;

    private void OnTriggerEnter(Collider other)
    {
        manager.OnTriggerBEntered();
    }
}
