using UnityEngine;
using UnityEngine.UI;

public class Nazhimay : MonoBehaviour
{
    public InputField inputField;  // Ссылка на InputField
    public Button button;          // Ссылка на Button

    void Start()
    {
        // Подписываемся на событие изменения текста
        inputField.onValueChanged.AddListener(CheckInput);
        
        // Изначально кнопка неактивна
        button.interactable = false;
    }

    void CheckInput(string text)
    {
        // Проверяем, что введено ровно 4 цифры
        bool isValid = text.Length == 4 && System.Text.RegularExpressions.Regex.IsMatch(text, "^[0-9]+$");
        
        // Активируем/деактивируем кнопку
        button.interactable = isValid;
    }

    void OnDestroy()
    {
        // Отписываемся от события при уничтожении объекта
        if (inputField != null)
            inputField.onValueChanged.RemoveListener(CheckInput);
    }
}