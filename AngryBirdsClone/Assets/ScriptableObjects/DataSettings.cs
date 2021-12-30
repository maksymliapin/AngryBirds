using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "DataSetting", order = 1)]
public class DataSettings : ScriptableObject
{
    public int numberBirds = 4;
    public float slingshotPower = 900.0f;
    public float pigArmor = 3.0f;
    public int firstStarPoints = 0;
    public int secondStarPoints = 1500;
    public int thirdStarPoints = 2000;
}
