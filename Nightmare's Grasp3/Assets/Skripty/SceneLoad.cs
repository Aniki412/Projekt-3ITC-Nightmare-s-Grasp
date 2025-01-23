using UnityEngine;

public class SceneLoad : MonoBehaviour
{
    public static Vector3 TargetPosition = Vector3.zero;
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
                if (TargetPosition == Vector3.zero)
                {
                    playerInstance.transform.position = new Vector3(-6, 0);
                    Debug.Log(playerInstance.transform.position);
                }
            }
        }
        if (!PlayerController.loading)
        {
            if (TargetPosition != Vector3.zero)
            {
                playerInstance.transform.position = TargetPosition;
                TargetPosition = Vector3.zero;
            }
        }
    }
}
