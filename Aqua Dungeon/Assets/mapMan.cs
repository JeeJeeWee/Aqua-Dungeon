using UnityEngine;

public class mapMan : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Panellocker;
    public GameObject Panelsmith;


    void Start()
    {
        Panel.SetActive(false);
        Panelsmith.SetActive(false);
        Panellocker.SetActive(false);

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (other.gameObject.CompareTag("Map"))
            {
                Panel.SetActive(true);

                Debug.Log("janeehupsakee");
            }
            else if (other.gameObject.CompareTag("smith"))
            {
                Panelsmith.SetActive(true);

                Debug.Log("janeehupsakee");
            }
            else if (other.gameObject.CompareTag("locker"))
            {
                Panellocker.SetActive(true);

                Debug.Log("janeehupsakee");
            }
            
        }
    }
}
