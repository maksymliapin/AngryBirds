using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public static int bestScore;
    [SerializeField] private Text textBestScoreEndGame;
    [SerializeField] private Text textScoreEndGame;
    [SerializeField] private Text textScore;
    private void Update()
    {
        textScore.text = "Score: " + score.ToString();
        textScoreEndGame.text = textScore.text;
        if (score > bestScore)
        {
            bestScore = score;
        }
        textBestScoreEndGame.text = "Best Score: " + bestScore.ToString();
    }
}
