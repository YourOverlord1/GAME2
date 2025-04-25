using UnityEngine;
using UnityEngine.SceneManagement;

public class PerehodLit : MonoBehaviour
{
    [SerializeField] private KeyCode interactKey = KeyCode.E; // Клавиша взаимодействия (можно поменять)
    [SerializeField] private GameObject hintUI; // Подсказка "Нажми E" (опционально)
    
    private bool playerInRange = false;

    // Проверка входа в триггер
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            if (hintUI != null) 
                hintUI.SetActive(true); // Показываем подсказку
        }
    }

    // Проверка выхода из триггера
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            if (hintUI != null) 
                hintUI.SetActive(false); // Скрываем подсказку
        }
    }

    // Проверка нажатия клавиши
    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(interactKey))
        {
            Transition();
        }
    }

    // Метод перехода на сцену
    public void Transition()
    {
        Debug.Log("Переход на сцену с индексом 17");
        SceneManager.LoadScene(20); // Загрузка сцены по индексу
    }
}