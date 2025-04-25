using System.Collections;
using DialogueEditor;
using UnityEngine;

public class GeographyDialogue : MonoBehaviour
{
    [SerializeField] private NPCConversation geographyConversation;
    [SerializeField] private GameObject hintUI;
    
    private bool playerInRange = false;
    private bool dialogueActive = false;
    private MonoBehaviour cameraMovementScript;
    private bool originalCursorState;
    private CursorLockMode originalCursorLockMode;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            cameraMovementScript = FindCameraController(other.gameObject);
            if (hintUI != null) hintUI.SetActive(true);
        }
    }

    private MonoBehaviour FindCameraController(GameObject player)
    {
        MonoBehaviour[] scripts = player.GetComponentsInChildren<MonoBehaviour>();
        foreach (var script in scripts)
        {
            if (script.GetType().Name.Contains("Look") || 
                script.GetType().Name.Contains("Rotate") ||
                script.GetType().Name.Contains("Camera"))
            {
                return script;
            }
        }
        return null;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            if (hintUI != null) hintUI.SetActive(false);
        }
    }

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.G) && !dialogueActive)
        {
            StartDialogue();
            if (hintUI != null) hintUI.SetActive(false);
        }
    }

    private void StartDialogue()
    {
        dialogueActive = true;
        
        originalCursorState = Cursor.visible;
        originalCursorLockMode = Cursor.lockState;
        
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        
        if (cameraMovementScript != null)
        {
            cameraMovementScript.enabled = false;
            Debug.Log("Найден и отключен скрипт камеры: " + cameraMovementScript.GetType().Name);
        }
        else
        {
            Debug.LogWarning("Не найден скрипт управления камерой!");
        }

        ConversationManager.OnConversationStarted += OnDialogueStarted;
        ConversationManager.OnConversationEnded += OnDialogueEnded;
        
        ConversationManager.Instance.StartConversation(geographyConversation);
    }

    private void OnDialogueStarted()
    {
        if (cameraMovementScript != null) 
            cameraMovementScript.enabled = false;
    }

    private void OnDialogueEnded()
    {
        dialogueActive = false;
        
        if (cameraMovementScript != null)
        {
            cameraMovementScript.enabled = true;
            Debug.Log("Скрипт камеры снова включен");
        }
        
        Cursor.visible = originalCursorState;
        Cursor.lockState = originalCursorLockMode;
        
        ConversationManager.OnConversationStarted -= OnDialogueStarted;
        ConversationManager.OnConversationEnded -= OnDialogueEnded;
    }

    private void OnDestroy()
    {
        ConversationManager.OnConversationStarted -= OnDialogueStarted;
        ConversationManager.OnConversationEnded -= OnDialogueEnded;
    }
}