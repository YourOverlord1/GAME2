using UnityEngine;
using UnityEngine.UI;

public class Stiray : MonoBehaviour
{
    private InputField inputField;

    void Start()
    {
        inputField = GetComponent<InputField>();
        inputField.onValueChanged.AddListener(OnValueChanged);
    }

    void OnValueChanged(string newValue)
    {
        // Проверяем, что ввод состоит только из цифр и их количество больше 4
        if (System.Text.RegularExpressions.Regex.IsMatch(newValue, "^[0-9]+$") && newValue.Length > 4)
        {
            // Стираем все символы
            inputField.text = "";
            
            // Опционально: можно вывести сообщение пользователю
            Debug.Log("Максимальное количество цифр - 4. Ввод очищен.");
        }
    }

    void OnDestroy()
    {
        // Не забываем отписаться от события при уничтожении объекта
        if (inputField != null)
        {
            inputField.onValueChanged.RemoveListener(OnValueChanged);
        }
    }
}