using Game;
using Settings;
using System.Collections;
using UnityEngine;

namespace Birds
{
    public class BirdGenerator : MonoBehaviour
    {
        [SerializeField] private DataSettings settings;
        [SerializeField] private GameObject prefabRedBird;
        [SerializeField] private GameObject prefabChuckBird;
        private Vector3 startingPosition;
        private int numberBirds;
        private int numberRedBirds;
        private int numberChuckBirds;
        private readonly float timeRespawnBird = 3.0f;

        private void Start()
        {
            Initialize();
        }

        public void CreateNextBird()
        {
            if (GameHelper.instance.isSlingshotFired)
            {
                if (GameHelper.instance.runningBirdsCounter < numberRedBirds)
                {
                    StartCoroutine("RebornRedWait");
                    GameHelper.instance.isSlingshotFired = false;
                }
                else if (GameHelper.instance.runningBirdsCounter < numberBirds)
                {
                    StartCoroutine("RebornChuckWait");
                    GameHelper.instance.isSlingshotFired = false;
                }
            }
        }

        public IEnumerator RebornRedWait()
        {
            yield return new WaitForSeconds(timeRespawnBird);
            Instantiate(prefabRedBird, startingPosition, Quaternion.identity);
        }

        public IEnumerator RebornChuckWait()
        {
            yield return new WaitForSeconds(timeRespawnBird);
            Instantiate(prefabChuckBird, startingPosition, Quaternion.identity);
        }

        private void Initialize()
        {
            numberRedBirds = settings.numberRedBirds;
            numberChuckBirds = settings.numberChuckBirds;
            numberBirds = numberRedBirds + numberChuckBirds;
            startingPosition = GetComponent<BaseBird>().startingPosition;
        }
    }
}