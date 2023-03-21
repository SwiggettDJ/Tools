using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public Vector3 value;

    public void UpdateValue(Vector3 nums)
    {
        value += nums;
    }
    
    public void ReplaceValue(Vector3 nums)
    {
        value = nums;
    }
    
    public void ResetValue(Vector3 nums)
    {
        value = Vector3.zero;
    }
}
