using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField] private TextAsset inkJSON;
    
    public void Trigger()
    {
        DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
    }
}
