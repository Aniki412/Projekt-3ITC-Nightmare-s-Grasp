using UnityEngine;

public class SceneLoad : MonoBehaviour
{
    public static Vector3 TargetPosition; 
    public static int TargetDirection;

    public GameObject PlayerPrefab;
    private static GameObject playerInstance;

    void Start()
    {
        if (playerInstance == null)
        {
            playerInstance = GameObject.FindWithTag("Player"); 

            if (playerInstance == null)
            {
                playerInstance = Instantiate(PlayerPrefab);
                DontDestroyOnLoad(playerInstance);
            }
        }

        if (TargetPosition != Vector3.zero)
        {
            playerInstance.transform.position = TargetPosition;

            PlayerController controller = playerInstance.GetComponent<PlayerController>();
            if (controller != null)
            {
                controller.SetDirection(TargetDirection);
            }
        }

    }
}
