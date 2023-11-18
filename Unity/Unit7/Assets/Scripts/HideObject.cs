using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HideObject : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public void HideTheObject()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }
}
