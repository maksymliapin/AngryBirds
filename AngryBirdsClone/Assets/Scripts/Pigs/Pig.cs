using Settings;
using UI;
using UnityEngine;

namespace Pigs
{
    public class Pig : MonoBehaviour
    {
        static public int deadPigCounter;
        public int numberPigs = 12;
        protected int pigPoints = 100;
        protected float pigArmor;
        protected const float timeDestroyBlast = 2.0f;
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
                DestroyPig();
            }
        }
        private void DestroyPig()
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