using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;


public class SaveSystem : MonoBehaviour
{
    private static string savePath = Application.persistentDataPath + "/savegame.json";

    public static void SaveGame(Vector3 playerPosition, string currentScene,List<string> dialogueVariables)
    {
        PlayerData data = new PlayerData(playerPosition, currentScene, dialogueVariables);
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(savePath, json);
        Debug.Log("Hra ulozena na: " + savePath);
    }

    public static PlayerData LoadGame()
    {
            string json = File.ReadAllText(savePath);
            PlayerData data = JsonUtility.FromJson<PlayerData>(json);
            Debug.Log("Hra nactena z: " + savePath);
            return data;
    }
}
