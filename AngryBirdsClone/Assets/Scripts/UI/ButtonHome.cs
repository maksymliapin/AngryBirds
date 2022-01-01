using Game;
using Pigs;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class ButtonHome : MonoBehaviour
    {
        private float changeSizeButton = 1.2f;
        private void OnMouseDown()
        {
            transform.localScale *= changeSizeButton;
        }
        private void OnMouseUp()
        {
            transform.localScale /= changeSizeButton;
            Score.score = 0;
            GameController.runningBirdsCounter = 0;
            Pig.deadPigCounter = 0;
            GameController.isSlingshotFired = false;
            SceneManager.LoadScene("SampleScene");
        }
    }
}