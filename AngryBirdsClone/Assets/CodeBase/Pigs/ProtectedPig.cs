namespace Pigs
{
    public class ProtectedPig : BasePig
    {
        private float protectedPigArmor = 2f;
        private int protectedPigPoints = 250;
        void Start()
        {
            basePigArmor += protectedPigArmor;
            basePigPoints = protectedPigPoints;
        }
    }
}