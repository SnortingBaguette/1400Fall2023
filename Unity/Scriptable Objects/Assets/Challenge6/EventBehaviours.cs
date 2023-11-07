using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventBehaviours : MonoBehaviour
{

    public UnityEvent onAwake, onDestruction, onEnteredTrigger, onGameStart, onNoParticles;

    private void OnParticleSystemStopped()
    {
        onNoParticles.Invoke();
    }

    private void Start()
    {
        onGameStart.Invoke();
    }
    private void Awake()
    {
        onAwake.Invoke();
    }

    private void OnDestroy()
    {
        onDestruction.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        onEnteredTrigger.Invoke();
        if (onEnteredTrigger != null)
        {
            GameObject.Destroy(gameObject);
        }
        
    }
}
