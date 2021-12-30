using UnityEngine;

public class ButtonPlay : MonoBehaviour
{
    [SerializeField] private GameObject startMenu;
    [SerializeField] private GameObject bird;
    [SerializeField] private GameObject scene;
    [SerializeField] private GameObject score;
    private float changeSizeButton = 1.2f;
    private void OnMouseDown()
    {
        transform.localScale = transform.localScale * changeSizeButton;
    }
    private void OnMouseUp()
    {
        transform.localScale = transform.localScale /changeSizeButton;
        startMenu.SetActive(false);
        bird.SetActive(false);
        scene.SetActive(true);
        score.SetActive(true);
    }
}
