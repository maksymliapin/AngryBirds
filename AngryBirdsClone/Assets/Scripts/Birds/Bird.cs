using Game;
using Settings;
using System.Collections;
using UnityEngine;

namespace Birds
{
    public class Bird : MonoBehaviour
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
            if (GameController.runningBirdsCounter < numberBirds && GameController.isSlingshotFired)
            {
                StartCoroutine("RebornWait");
                GameController.isSlingshotFired = false;
            }
            if (EndGameController.isGameFinished == true && gameObject != null)
            {
                Destroy(gameObject, delay);
                EndGameController.isGameFinished = false;
            }
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(gameObject, timeDestroyBird);
        }
        public IEnumerator RebornWait()
        {
            yield return new WaitForSeconds(timeRespawnBird);
            Instantiate(gameObject, startingPosition, Quaternion.identity);
        }
    }
}