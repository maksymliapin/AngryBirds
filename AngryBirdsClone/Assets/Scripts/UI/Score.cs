using Game;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class Score : MonoBehaviour
    {
        public static int bestScore;
        [SerializeField] private Text textBestScoreEndGame;
        [SerializeField] private Text textScoreEndGame;
        [SerializeField] private Text textScore;
        private void Update()
        {
            ShowScore();
            ShowBestScore();
        }
        private void ShowScore()
        {
            textScore.text = "Score: " + GameHelper.instance.score.ToString();
            textScoreEndGame.text = textScore.text;
        }
        private void ShowBestScore()
        {
            if (GameHelper.instance.score > bestScore)
            {
                bestScore = GameHelper.instance.score;
            }
            textBestScoreEndGame.text = "Best Score: " + bestScore.ToString();
        }
    }
}