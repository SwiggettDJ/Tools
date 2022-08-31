using UnityEngine;

[CreateAssetMenu]
public class StringData : ScriptableObject
{
    public string value;

    public void AppendValue(string txt)
    {
        value += txt;
    }
    
    public void ReplaceValue(string txt)
    {
        value = txt;
    }
    
    public void ResetValue(string txt)
    {
        value = "";
    }
}
