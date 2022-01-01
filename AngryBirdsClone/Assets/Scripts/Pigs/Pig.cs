using Settings;
using UI;
using UnityEngine;

namespace Pigs
{
    public class Pig : MonoBehaviour
    {
        public int numberPigs = 12;
        public int pigPoints = 100;
        public float pigArmor;
        public const float timeDestroyBlast = 2.0f;
        static public int deadPigCounter;
        [SerializeField] private DataSettings settings;
        [SerializeField] private GameObject blast;
        private bool isPigDied;
        private void Awake()
        {
            pigArmor = settings.pigArmor;
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.relativeVelocity.magnitude > pigArmor && isPigDied == false)
            {
                isPigDied = true;
                Destroy(gameObject);
                Score.score += pigPoints;
                deadPigCounter++;
                var bang = Instantiate(blast, transform.position, Quaternion.identity);
                Destroy(bang, timeDestroyBlast);
            }
        }
    }
}