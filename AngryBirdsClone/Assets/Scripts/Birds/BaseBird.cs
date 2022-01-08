using Game;
using Settings;
using System.Collections;
using UnityEngine;

namespace Birds
{
    public abstract class BaseBird : MonoBehaviour
    {
        public Vector3 startingPosition;
        [SerializeField] private DataSettings settings;
        private float timeDestroyBird = 3.0f;
        private float timeRespawnBird = 3.0f;
        private float delay = 2.0f;
        private int numberBirds;
        private void Start()
        {
            numberBirds = settings.numberBirds;
            startingPosition = transform.position;
            gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
        }
        private void Update()
        {
            ÑreateNextBird();
            DestroyBirdEndGame();
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(gameObject, timeDestroyBird);
        }
        private void ÑreateNextBird()
        {
            if (GameHelper.instance.runningBirdsCounter < numberBirds && GameHelper.instance.isSlingshotFired)
            {
                StartCoroutine("RebornWait");
                GameHelper.instance.isSlingshotFired = false;
            }
        }
        private void DestroyBirdEndGame()
        {
            if (GameHelper.instance.isGameFinished && gameObject != null)
            {
                Destroy(gameObject, delay);
                GameHelper.instance.isGameFinished = false;
            }
        }
        public IEnumerator RebornWait()
        {
            yield return new WaitForSeconds(timeRespawnBird);
            Instantiate(gameObject, startingPosition, Quaternion.identity);
        }
    }
}


