using UnityEngine;
using UnityEngine.UI;

public class AttemptsCounter : MonoBehaviour
{
    public Text counter;
    [SerializeField] private DataSettings setiings;
    private int numberAttempts; 
    void Start()
    {
        numberAttempts = setiings.numberBirds;
    }
    void Update()
    {
        var attempts = numberAttempts - Game—ontroller.runningBirdsCounter;
        counter.text = attempts.ToString();
    }
}
