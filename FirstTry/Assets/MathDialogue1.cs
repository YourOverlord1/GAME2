using UnityEngine;
using DialogueEditor;

public class MathDialogue1 : MonoBehaviour
{
    // [Header("Dialogue Settings")]
    // [SerializeField] private NPCConversation mathConversation;
    // [SerializeField] private GameObject hintUI;
    // [SerializeField] private Transform dialogueAnchor; // Новая настройка позиции диалога
    
    // [Header("Player Control")]
    // [SerializeField] private bool disableCameraMovement = true;
    // [SerializeField] private bool disablePlayerMovement = true;
    
    // [Header("UI Settings")]
    // [SerializeField] private bool showCursor = true;
    // [SerializeField] private CursorLockMode cursorLockMode = CursorLockMode.None;

    // private bool playerInRange = false;
    // private bool dialogueActive = false;
    // private MonoBehaviour cameraMovementScript;
    // private MonoBehaviour playerMovementScript;
    // private bool originalCursorState;
    // private CursorLockMode originalCursorLockMode;

    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.CompareTag("Player"))
    //     {
    //         playerInRange = true;
    //         FindPlayerComponents(other.gameObject);
    //         if (hintUI != null) hintUI.SetActive(true);
    //     }
    // }

    // private void FindPlayerComponents(GameObject player)
    // {
    //     // Поиск компонентов управления
    //     MonoBehaviour[] scripts = player.GetComponentsInChildren<MonoBehaviour>();
    //     foreach (var script in scripts)
    //     {
    //         if (script.GetType().Name.Contains("Look") || 
    //             script.GetType().Name.Contains("Rotate") ||
    //             script.GetType().Name.Contains("Camera"))
    //         {
    //             cameraMovementScript = script;
    //         }
    //         if (script.GetType().Name.Contains("Movement") ||
    //             script.GetType().Name.Contains("Controller"))
    //         {
    //             playerMovementScript = script;
    //         }
    //     }
    // }

    // private void OnTriggerExit(Collider other)
    // {
    //     if (other.CompareTag("Player"))
    //     {
    //         playerInRange = false;
    //         if (hintUI != null) hintUI.SetActive(false);
    //     }
    // }

    // private void Update()
    // {
    //     if (playerInRange && Input.GetKeyDown(KeyCode.G) && !dialogueActive)
    //     {
    //         Debug.Log("Клавиша G нажата - начало диалога"); // Добавлено сообщение в консоль
    //         if (ConversationManager.Instance != null && !ConversationManager.Instance.IsConversationActive)
    //         {
    // //            StartDialogue();
    //         }
    //     }
    // }

    // private void StartDialogue()
    // {
    //     if (mathConversation == null)
    //     {
    //         Debug.LogError("Math conversation not assigned!");
    //         return;
    //     }

    //     dialogueActive = true;

    //     // Сохраняем оригинальные настройки
    //     originalCursorState = Cursor.visible;
    //     originalCursorLockMode = Cursor.lockState;

    //     // Настройка курсора
    //     Cursor.visible = showCursor;
    //     Cursor.lockState = cursorLockMode;

    //     // Отключение управления
    //     SetPlayerControl(false);

        
    //     // Подписка на события
    //     ConversationManager.OnConversationStarted += OnDialogueStarted;
    //     ConversationManager.OnConversationEnded += OnDialogueEnded;

    //     // Запуск диалога
    //     ConversationManager.Instance.StartConversation(mathConversation);
    // }

    // private void SetPlayerControl(bool state)
    // {
    //     if (disableCameraMovement && cameraMovementScript != null)
    //         cameraMovementScript.enabled = state;

    //     if (disablePlayerMovement && playerMovementScript != null)
    //         playerMovementScript.enabled = state;
    // }

    // private void OnDialogueStarted()
    // {
    //     // Дополнительные действия при старте
    //     Debug.Log("Math dialogue started");
    // }

    // private void OnDialogueEnded()
    // {
    //     dialogueActive = false;
        
    //     // Восстановление управления
    //     SetPlayerControl(true);
        
    //     // Восстановление курсора
    //     Cursor.visible = originalCursorState;
    //     Cursor.lockState = originalCursorLockMode;

    //     // Отписка от событий
    //     ConversationManager.OnConversationStarted -= OnDialogueStarted;
    //     ConversationManager.OnConversationEnded -= OnDialogueEnded;
    // }

    // private void OnDestroy()
    // {
    //     ConversationManager.OnConversationStarted -= OnDialogueStarted;
    //     ConversationManager.OnConversationEnded -= OnDialogueEnded;
    // }
}