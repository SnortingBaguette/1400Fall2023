using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class MonoEventsBehaviour : MonoBehaviour
{

    public UnityEvent startEvent, awakeEvent, disableEvent;
    // Start is called before the first frame update
    private void Awake()
    {
        awakeEvent.Invoke();
    }
    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }
}
