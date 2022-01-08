using Pigs;
using Settings;
using System.Collections;
using UI;
using UnityEngine;

namespace Game
{
    public class EndGameController : MonoBehaviour
    {
        [SerializeField] private DataSettings settings;
        [SerializeField] private GameObject firstStar;
        [SerializeField] private GameObject secondStar;
        [SerializeField] private GameObject thirdStar;
        [SerializeField] private GameObject score;
        [SerializeField] private GameObject scene;
        [SerializeField] private GameObject menuAndGame;
        private int firstStarPoints;
        private int secondStarPoints;
        private int thirdStarPoints;
        private const float delay = 4.0f;
        private int numberBirds;
        void Start()
        {
            numberBirds = settings.numberBirds;
            firstStarPoints = settings.firstStarPoints;
            secondStarPoints = settings.secondStarPoints;
            thirdStarPoints = settings.thirdStarPoints;
        }
        void Update()
        {
            ShowEndGameMenu();
        }
        private void ShowEndGameMenu()
        {
            if (GameHelper.instance.runningBirdsCounter == numberBirds || GameHelper.instance.deadPigCounter == GameHelper.instance.numberPigs && GameHelper.instance.isGameFinished != true)
            {
                StartCoroutine("HoldUpTime");
                GameHelper.instance.isGameFinished = true;
            }
        }
        public IEnumerator HoldUpTime()
        {
            yield return new WaitForSeconds(delay);
            if (GameHelper.instance.score >= 0)
            {
                score.SetActive(false);
                scene.SetActive(false);
                menuAndGame.SetActive(true);
            }
            if (GameHelper.instance.score >= firstStarPoints)
            {
                firstStar.SetActive(true);
            }
            if (GameHelper.instance.score >= secondStarPoints)
            {
                secondStar.SetActive(true);
            }
            if (GameHelper.instance.score >= thirdStarPoints)
            {
                thirdStar.SetActive(true);
            }
        }
    }
}