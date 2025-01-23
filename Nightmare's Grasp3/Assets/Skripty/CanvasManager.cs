using Unity.VisualScripting;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{ 
    public GameObject LoadingScreen;
    public GameObject SaveCanvas;
    public GameObject LoadCanvas;
    void Awake()
    {
        LoadingScreen = GameObject.FindWithTag("LoadingScreen");
        SaveCanvas = GameObject.FindWithTag("SaveCanvas");
        LoadCanvas = GameObject.FindWithTag("LoadCanvas");
    }

    public void CanvasLoad(string canvasTag, float delay)
    {
        switch (canvasTag)
        {
            case "LoadingScreen":
                    LoadingScreen.SetActive(true);
                    StartCoroutine(DelayHide(LoadingScreen, delay));
                break;
            case "SaveCanvas":
                    SaveCanvas.SetActive(true);
                    StartCoroutine(DelayHide(SaveCanvas, delay));  
                break;
            case "LoadCanvas":
                    LoadCanvas.SetActive(true);
                    StartCoroutine(DelayHide(LoadCanvas, delay));
                break;
            default:
                Debug.LogError("Neznámý tag pro Canvas: " + canvasTag);
                break;
        }
    }
    public void CanvasHide()
    {
        LoadingScreen = GameObject.FindWithTag("LoadingScreen");
        SaveCanvas = GameObject.FindWithTag("SaveCanvas");
        LoadCanvas = GameObject.FindWithTag("LoadCanvas");
        LoadingScreen.SetActive(false);
        SaveCanvas.SetActive(false);
        LoadCanvas.SetActive(false);
    }
    private IEnumerator DelayHide(GameObject canvas, float delay)
    { 
        yield return new WaitForSeconds(delay);
        canvas.SetActive(false);
    }
    
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        CanvasHide();
    }
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}