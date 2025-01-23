
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance { get; private set; }
    private CanvasManager canvasManager;
    private Animator animator;
    private List<string> dialogueVariables = new List<string>();
    public static bool loading = false;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    private void Start()
    {
        canvasManager = FindFirstObjectByType<CanvasManager>();
        if(canvasManager.LoadingScreen.activeSelf || canvasManager.SaveCanvas.activeSelf || canvasManager.LoadCanvas.activeSelf)
        {
            canvasManager.CanvasHide();
        }
    }
    public void SaveGame()
    {
        SaveSystem.SaveGame(transform.position, SceneManager.GetActiveScene().name, dialogueVariables);
    }
    public void LoadGame()
    {
        loading = true;
        PlayerData data = SaveSystem.LoadGame();
            dialogueVariables = data.dialogueVariables ?? new List<string>();
            SceneManager.sceneLoaded += (scene, mode) => {
                if (scene.name == data.currentScene)
                {
                    transform.position = new Vector3(data.positionX, data.positionY, data.positionZ);
                    SceneManager.sceneLoaded -= null;
                }
            };
            SceneManager.LoadScene(data.currentScene);
            loading = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            canvasManager.CanvasLoad("SaveCanvas", 1f);
            SaveGame();
        }
        if (Input.GetKeyDown(KeyCode.F9))
        {
            canvasManager.CanvasLoad("LoadCanvas", 1f);
            LoadGame();
        }
    }
    public void SetDirection(int smer)
    {
        if (animator != null)
        {
            animator.SetInteger("Smer", smer);
        }
    }
    public void SetDialogueVariable(string key, bool value)
    {
        if (value)
        {
            if (!dialogueVariables.Contains(key))
            {
                dialogueVariables.Add(key);
            }
        }
        else
        {
            dialogueVariables.Remove(key);
        }
    }
    public bool GetDialogueVariable(string key)
    {
        return dialogueVariables.Contains(key);
    }
}
