using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;

    public void UpdateValue(float num)
    {
        value += num;
    }
    
    public void ReplaceValue(float num)
    {
        value = num;
    }
    
    public void ResetValue(float num)
    {
        value = 0f;
    }

    public void DebugValue()
    {
        Debug.Log(this.name + " has a value of " + value);
    }
}
