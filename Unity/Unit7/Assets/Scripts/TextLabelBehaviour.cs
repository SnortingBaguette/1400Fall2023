using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextLabelBehaviour : MonoBehaviour
{
    private Text labelLegacy;
    private TextMeshProUGUI label;
    public UnityEvent startEvent;

    private void Start()
    {
        label = GetComponent<TextMeshProUGUI>();
        labelLegacy = GetComponent<Text>();
        startEvent.Invoke();
    }

    public void UpdateLabel(FloatData obj)
    {
        label.text = obj.value.ToString();
    }
    public void UpdateLabelLegacy(FloatData obj)
    {
        labelLegacy.text = obj.value.ToString();
    }

    public void UpdateLabel(IntData obj)
    {
        label.text = obj.value.ToString();
    }

    public void UpdateLabelLegacy(IntData obj)
    {
        labelLegacy.text = obj.value.ToString();
    }
}
