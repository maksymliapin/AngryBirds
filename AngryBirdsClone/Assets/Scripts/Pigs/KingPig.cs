
public class KingPig : Pig
{
    private float kingPigArmor = 3f;
    private int kingPigPoints = 500;
    void Start()
    {
        pigArmor += kingPigArmor;
        pigPoints = kingPigPoints;
    }
}
