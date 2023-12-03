using UnityEngine;

public class GameObjectDisabler : MonoBehaviour
{
    private void OnEnable()
    {
        var triggerEventsBehaviour = FindFirstObjectByType<TriggerEventsBehaviour>();
        if (triggerEventsBehaviour != null)
        {
            triggerEventsBehaviour.triggerExitEvent.AddListener(DisableGameObject);
        }
    }

    private void OnDisable()
    {
        var triggerEventsBehaviour = FindFirstObjectByType<TriggerEventsBehaviour>();
        if (triggerEventsBehaviour != null)
        {
            triggerEventsBehaviour.triggerExitEvent.RemoveListener(DisableGameObject);
        }
    }

    private void DisableGameObject()
    {
        gameObject.SetActive(false);
    }
}