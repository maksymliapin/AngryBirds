namespace Pigs
{
    public class Pig : BasePig
    {
        private float pigArmor = 1.0f;
        private int pigPoints = 100;
        void Start()
        {
            basePigArmor += pigArmor;
            basePigPoints = pigPoints;
        }
    }
}