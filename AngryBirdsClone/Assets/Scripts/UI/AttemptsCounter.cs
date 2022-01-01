using Game;
using Settings;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
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
            var attempts = numberAttempts - GameController.runningBirdsCounter;
            counter.text = attempts.ToString();
        }
    }
}