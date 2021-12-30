using System.Collections;
using UnityEngine;

public class EndGameController : MonoBehaviour
{
    [SerializeField] private DataSettings settings;
    [SerializeField] private GameObject firstStar;
    [SerializeField] private GameObject secondStar;
    [SerializeField] private GameObject thirdStar;
    [SerializeField] private GameObject score;
    [SerializeField] private GameObject scene;
    [SerializeField] private GameObject menuAndGame;
    [SerializeField] private Pig prefabPig;
    private int firstStarPoints;
    private int secondStarPoints;
    private int thirdStarPoints;
    private const float delay = 4.0f;
    private int numberBirds;
    private int numberPigs;
    void Start()
    {
        numberBirds = settings.numberBirds;
        numberPigs = prefabPig.GetComponent<Pig>().numberPigs;
        firstStarPoints = settings.firstStarPoints;
        secondStarPoints = settings.secondStarPoints;
        thirdStarPoints = settings.thirdStarPoints;
    }
    void Update()
    {
        if (GameÑontroller.runningBirdsCounter == numberBirds || Pig.deadPigCounter == numberPigs)
        {
            StartCoroutine("HoldUpTimeOne");
        }
    }
    public IEnumerator HoldUpTimeOne()
    {
        yield return new WaitForSeconds(delay);
        if (Score.score >= 0)
        {
            score.SetActive(false);
            scene.SetActive(false);
            menuAndGame.SetActive(true);
        }
        if (Score.score >= firstStarPoints)
        {
            firstStar.SetActive(true);
        }
        if (Score.score >= secondStarPoints)
        {
            secondStar.SetActive(true);
        }
        if (Score.score >= thirdStarPoints)
        {
            thirdStar.SetActive(true);
        }
    }
}
