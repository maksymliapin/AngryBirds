using Game;
using Settings;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.UI
{
    public class AttemptsCounter : MonoBehaviour
    {
        public Text counterRed;
        public Text counterChuck;
        [SerializeField] private DataSettings setiings;
        private int numberAttemptsRedBirds;
        private int numberAttemptsChuckBirds;
        void Start()
        {
            Initialize();
        }
        void Update()
        {
            ShowAttempts();
        }
        private void ShowAttempts()
        {
            var attemptsRed = numberAttemptsRedBirds - GameHelper.instance.runningRedCounter;
            counterRed.text = attemptsRed.ToString();
            var attemptsChuck = numberAttemptsChuckBirds - GameHelper.instance.runningChuckCounter;
            counterChuck.text = attemptsChuck.ToString();
        }
        private void Initialize()
        {
            numberAttemptsRedBirds = setiings.numberRedBirds;
            numberAttemptsChuckBirds = setiings.numberChuckBirds;
        }
    }
}