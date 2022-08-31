namespace Pigs
{
    public class MiniPig : BasePig
    {
        private float miniPigArmor = -1.0f;
        private int miniPigPoints = 50;
        void Start()
        {
            basePigArmor += miniPigArmor;
            basePigPoints = miniPigPoints;
        }
    }
}