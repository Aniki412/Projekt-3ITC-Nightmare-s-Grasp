using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float positionX;
    public float positionY;
    public float positionZ;
    public string currentScene;
    public List<string> dialogueVariables = new List<string>();
    public PlayerData(Vector3 position, string scene,List<string> variables)
    {
        positionX = position.x;
        positionY = position.y;
        positionZ = position.z;
        currentScene = scene;
        dialogueVariables = new List<string>(variables);
    }
}
