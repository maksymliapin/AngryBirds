using UnityEngine;

namespace Birds
{
    public class RedBird : BaseBird
    {
        private float massRedBird = 3;
        private void Awake()
        {
            GetComponent<Rigidbody2D>().mass = massRedBird;
        }
    }
}