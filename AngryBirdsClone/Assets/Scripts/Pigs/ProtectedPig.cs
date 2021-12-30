
public class ProtectedPig : Pig
{
    private float protectedPigArmor = 2f;
    private int protectedPigPoints = 250;
    void Start()
    {
        pigArmor += protectedPigArmor;
        pigPoints = protectedPigPoints;
    }
}
