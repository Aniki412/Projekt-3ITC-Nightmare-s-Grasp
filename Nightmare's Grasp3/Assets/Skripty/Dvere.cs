using System;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dvere : MonoBehaviour
{
    public string TargetScene;
    public Vector3 TargetPosition;
    public string RequiredVariable;
    private CanvasManager canvasManager;
    public void OpenDoor()
    {
        canvasManager = FindFirstObjectByType<CanvasManager>();
        if (string.IsNullOrEmpty(RequiredVariable) || PlayerController.Instance.GetDialogueVariable(RequiredVariable))
        {
            SceneLoad.TargetPosition = TargetPosition;
            SceneManager.LoadScene(TargetScene);
            canvasManager.CanvasLoad("LoadingScreen", 0.2f);
        }
        else
        {
            Debug.Log("Dvere zavrene");
        }
    }
}