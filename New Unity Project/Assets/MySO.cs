using UnityEngine;
[CreateAssetMenu]
public class MySO : ScriptableObject
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
}
