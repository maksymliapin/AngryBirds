namespace Pigs
{
    public class BaleenPig : BasePig
    {
        private float baleenPigArmor = 2.0f;
        private int baleenPigPoints = 400;
        void Start()
        {
            basePigArmor += baleenPigArmor;
            basePigPoints = baleenPigPoints;
        }
    }
}