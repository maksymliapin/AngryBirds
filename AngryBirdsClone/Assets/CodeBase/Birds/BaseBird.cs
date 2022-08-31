using Game;
using Settings;
using UnityEngine;

namespace Birds
{
    public abstract class BaseBird : MonoBehaviour
    {
        public Vector3 startingPosition;
        [SerializeField] private DataSettings settings;
        private BirdGenerator birdGenerator;
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
            birdGenerator.CreateNextBird();
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
            birdGenerator = GetComponent<BirdGenerator>();
        }


        public int CheckParam()
        {
            bool resalt;
            int firstNumber;
            
            do
            {
                resalt = int.TryParse("5", out var number);
                firstNumber = number;

            } while (resalt == false);

            return firstNumber;
        }
    }
}


