using Game;
using Settings;
using UI;
using UnityEngine;

namespace Pigs
{
    public class Pig : MonoBehaviour
    {
        protected int pigPoints = 100;
        protected float pigArmor;
        protected const float timeDestroyBlast = 2.0f;
        [SerializeField] private DataSettings settings;
        [SerializeField] private GameObject blast;
        private bool isPigDied;
        private void Awake()
        {
            pigArmor = settings.pigArmor;
            GameHelper.instance.numberPigs++;
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
            GameHelper.instance.score += pigPoints;
            GameHelper.instance.deadPigCounter++;
            var bang = Instantiate(blast, transform.position, Quaternion.identity);
            Destroy(bang, timeDestroyBlast);
        }
    }
}