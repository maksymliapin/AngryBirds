namespace Pigs
{
    public class MiniPig : Pig
    {
        private float miniPigArmor = -1f;
        private int miniPigPoints = 50;
        void Start()
        {
            pigArmor += miniPigArmor;
            pigPoints = miniPigPoints;
        }
    }
}