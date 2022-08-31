using UnityEngine;

namespace Game
{
    public class GameHelper : MonoBehaviour
    {
        public static GameHelper instance;
        public int score;
        public int numberPigs;
        public int deadPigCounter;
        public bool isSlingshotFired;
        public int runningBirdsCounter;
        public int runningRedCounter;
        public int runningChuckCounter;
        public bool isGameFinished;
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else if (instance == this)
            {
                Destroy(gameObject);
            }
        }
    }
}

