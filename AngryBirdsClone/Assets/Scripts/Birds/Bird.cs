using System.Collections;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Vector3 startingPosition;
    public const float timeDestroyBird = 3.0f;
    public const float timeRespawnBird = 2.0f;
    [SerializeField] private  DataSettings settings;
    private int numberBirds;
    private void Start()
    {
        numberBirds = settings.numberBirds;
        startingPosition = transform.position;
        gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
    }
    private void Update()
    {
        if (Game—ontroller.runningBirdsCounter < numberBirds && Game—ontroller.isSlingshotFired)
        {
            StartCoroutine("RebornWait");
            Game—ontroller.isSlingshotFired = false;
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
