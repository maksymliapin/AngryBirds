using UnityEngine;

namespace Birds
{
    public class ChuckBird : BaseBird
    {
        private readonly float massRedBird = 2.0f;
        private void Awake()
        {
            GetComponent<Rigidbody2D>().mass = massRedBird;
        }
    }
}

