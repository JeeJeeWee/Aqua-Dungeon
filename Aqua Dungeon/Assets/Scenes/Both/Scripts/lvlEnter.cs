// Immediate death trigger.
// Destroys any colliders that enter the trigger, if they are tagged player.
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvlEnter : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (other.gameObject.CompareTag("Glass"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}