using UnityEngine;

public class PopUp : MonoBehaviour
{
    private GameObject popup; 

    private void Awake()
    {
        popup = transform.Find("Popup")?.gameObject;
        popup.SetActive(false); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            popup.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            popup.SetActive(false);   
        }
    }
}
