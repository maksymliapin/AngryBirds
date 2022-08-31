namespace Pigs
{
    public class KingPig : BasePig
    {
        private float kingPigArmor = 3.0f;
        private int kingPigPoints = 500;
        void Start()
        {
            basePigArmor += kingPigArmor;
            basePigPoints = kingPigPoints;
        }
    }
}