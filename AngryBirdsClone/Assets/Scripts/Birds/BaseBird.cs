using Game;
using Settings;
using UnityEngine;

namespace Birds
{
    public abstract class BaseBird : MonoBehaviour
    {
        public Vector3 startingPosition;
        [SerializeField] private DataSettings settings;
        private BirdGeneraitor birdGeneraitor;
        private float timeDestroyBird = 3.0f;
        private float delay = 2.0f;
        private int numberRedBirds;
        private int numberChuckBirds;
        private void Start()
        {
            Initialize();
            gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
        }
        private void Update()
        {
            birdGeneraitor.ÑreateNextBird();
            DestroyBirdEndGame();
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(gameObject, timeDestroyBird);
        }
        private void DestroyBirdEndGame()
        {
            if (GameHelper.instance.isGameFinished)
            {
                Destroy(gameObject, delay);
                GameHelper.instance.isGameFinished = false;
            }
        }
        private void Initialize()
        {
            numberRedBirds = settings.numberRedBirds;
            numberChuckBirds = settings.numberChuckBirds;
            startingPosition = transform.position;
            birdGeneraitor = GetComponent<BirdGeneraitor>();
        }
    }
}


