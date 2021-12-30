using UnityEngine;
using UnityEngine.SceneManagement;

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
        GameŅontroller.runningBirdsCounter = 0;
        Pig.deadPigCounter = 0;
        GameŅontroller.isSlingshotFired = false;
        SceneManager.LoadScene("SampleScene");
    }
}
