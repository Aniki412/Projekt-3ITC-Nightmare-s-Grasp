using UnityEngine;

public class Odpadek : MonoBehaviour
{
    public void Sebrat()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            PlayerController playerController = player.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.PridatOdpadek();
                Debug.Log("negr");
            }
        }
        Destroy(gameObject);
    }
}
