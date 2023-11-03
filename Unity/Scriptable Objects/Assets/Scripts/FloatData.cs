
using UnityEngine;

[CreateAssetMenu(fileName ="New Float Data",menuName ="Float Data")]
public class FloatData : ScriptableObject
{

    public void SetValue(float num)
    {
        value = num;
    }
    [SerializeField] private float value;
    public float Value
    {
        get { return value; }

        set {this.value = value;}
    }
    public void UpdateValue(float num)
    {
        Value += num;
    }
}
