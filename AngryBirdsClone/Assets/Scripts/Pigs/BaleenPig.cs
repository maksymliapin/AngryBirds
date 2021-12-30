
public class BaleenPig : Pig
{
    private float baleenPigArmor = 2f;
    private int baleenPigPoints = 400;
    void Start()
    {
        pigArmor += baleenPigArmor;
        pigPoints = baleenPigPoints;
    }
}
