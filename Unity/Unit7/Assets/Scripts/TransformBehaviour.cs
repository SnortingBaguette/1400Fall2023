using UnityEngine;

public class TransformBehaviour : MonoBehaviour
{
    public SpriteRenderer renderer;
    public void ResetToZero(GameObject obj)
    {
        obj.transform.position = Vector3.zero;
        renderer = obj.GetComponent<SpriteRenderer>();
        renderer.enabled = true;
    }
}
