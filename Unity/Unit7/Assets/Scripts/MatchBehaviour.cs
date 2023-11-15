using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{

    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent;

    private void OnTriggerEnter(Collider other)
    {

        var tempID = other.GetComponent<IDContainerBehaviour>();
        if (tempID == null)
            return;

        var otherID = tempID.idObj;

        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
        }
    }
}
