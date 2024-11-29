using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dvere : MonoBehaviour
{
    public string TargetScene;
    public Vector3 TargetPosition;

    public void OpenDoor()
    {
        SceneLoad.TargetPosition = TargetPosition;
        SceneManager.LoadScene(TargetScene);
    }
}
