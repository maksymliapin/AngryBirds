using UnityEngine;

namespace CodeBase.UI
{
    public class ButtonPlay : MonoBehaviour
    {
        [SerializeField] private GameObject startMenu;
        [SerializeField] private GameObject bird;
        [SerializeField] private GameObject scene;
        [SerializeField] private GameObject score;
        private float changeSizeButton = 1.2f;
        private void OnMouseDown()
        {
            transform.localScale *= changeSizeButton;
        }
        private void OnMouseUp()
        {
            transform.localScale /= changeSizeButton;
            StartGame();
        }
        private void StartGame()
        {
            startMenu.SetActive(false);
            bird.SetActive(false);
            scene.SetActive(true);
            score.SetActive(true);
            var menu = Resources.Load<GameObject>("Menu/SkinMenu");
            Instantiate(menu);
        }
    }
}