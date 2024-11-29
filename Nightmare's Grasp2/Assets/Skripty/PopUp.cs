using UnityEngine;

public class PopUp : MonoBehaviour
{
    private GameObject popup; 

    private void Awake()
    {
        popup = transform.Find("Popup")?.gameObject;

        if (popup == null)
        {
            Debug.LogError("Neexistuje Popup");
        }
        else
        {
            popup.SetActive(false); 
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (popup != null)
            {
                popup.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (popup != null)
            {
                popup.SetActive(false);
            }
        }
    }
}
