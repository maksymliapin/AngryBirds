using Birds;
using UnityEngine;

namespace Building
{
    public class WoodenStructure : MonoBehaviour
    {
        [SerializeField] private GameObject blast;
        protected const float timeDestroyBlast = 0.5f;
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.GetComponent<ChuckBird>())
            {
                Destroy(gameObject);
                var bang = Instantiate(blast, transform.position, Quaternion.identity);
                Destroy(bang, timeDestroyBlast);
            }
        }
    }
}
