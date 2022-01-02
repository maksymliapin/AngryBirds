using Birds;
using Settings;
using UnityEngine;

namespace Game
{
    public class GameController : MonoBehaviour
    {
        public static int runningBirdsCounter;
        public static bool isSlingshotFired;
        [SerializeField] private DataSettings settings;
        private Bird selectedBird;
        private float slingshotPower;
        private float maxTensionForward = -4f;
        private void Start()
        {
            slingshotPower = settings.slingshotPower;
        }
        private void Update()
        {
            var cursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Input.GetMouseButtonDown(0) && selectedBird == null)
            {
                Collider2D[] selectedColliders = Physics2D.OverlapCircleAll(cursor, 0.1f);
                foreach (var item in selectedColliders)
                {
                    if (item.GetComponent<Bird>())
                    {
                        selectedBird = item.GetComponent<Bird>();
                        break;
                    }
                }
            }
            if (selectedBird != null)
            {
                MoveBird(cursor);
                RotateBird(selectedBird);
                if ( selectedBird.transform.position.x >= maxTensionForward)
                {
                    shootBird();
                    selectedBird = null;
                }
            }
            if (Input.GetMouseButtonUp(0))
            {
                if (selectedBird != null)
                {
                    shootBird();
                }
                selectedBird = null;
            }
        }
        private void RotateBird(Bird bird)
        {
            var dir = bird.startingPosition - new Vector3(bird.transform.position.x, bird.transform.position.y);
            var angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
            bird.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        private void MoveBird(Vector3 cursor)
        {
            selectedBird.transform.position = Vector2.MoveTowards(selectedBird.transform.position, new Vector2(cursor.x, cursor.y), Time.deltaTime * 5.0f);
        }
        private void shootBird()
        {
            var body = selectedBird.GetComponent<Rigidbody2D>();
            body.isKinematic = false;
            if (selectedBird.transform.position.x >= maxTensionForward)
            {
                body.AddForce(new Vector2(selectedBird.startingPosition.x + selectedBird.transform.position.x, selectedBird.startingPosition.y + selectedBird.transform.position.y) * slingshotPower);
            }
            else if (selectedBird.transform.position.x < maxTensionForward)
            {
                body.AddForce(new Vector2(selectedBird.startingPosition.x - selectedBird.transform.position.x, selectedBird.startingPosition.y - selectedBird.transform.position.y) * slingshotPower);
            }
            GetComponent<AudioSource>().PlayDelayed(0);
            isSlingshotFired = true;
            runningBirdsCounter++;
        }
    }
}