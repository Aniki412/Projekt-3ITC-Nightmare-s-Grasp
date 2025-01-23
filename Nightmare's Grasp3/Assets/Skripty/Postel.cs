using UnityEngine;
using UnityEngine.SceneManagement;

public class Postel : MonoBehaviour
{
    public Vector3 TargetPosition;

    public void Sleep()
    {
        SceneLoad.TargetPosition = TargetPosition;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
