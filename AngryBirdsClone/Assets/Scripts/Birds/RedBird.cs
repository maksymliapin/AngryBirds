using UnityEngine;

namespace Birds
{
    public class RedBird : BaseBird
    {
        private float massRedBird = 4.0f;
        private void Awake()
        {
            GetComponent<Rigidbody2D>().mass = massRedBird;
        }
    }
}