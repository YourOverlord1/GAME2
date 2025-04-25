using UnityEngine;
using UnityEngine.UI;

public class Nazhimay : MonoBehaviour
{
    public InputField inputField;  // ������ �� InputField
    public Button button;          // ������ �� Button

    void Start()
    {
        // ������������� �� ������� ��������� ������
        inputField.onValueChanged.AddListener(CheckInput);
        
        // ���������� ������ ���������
        button.interactable = false;
    }

    void CheckInput(string text)
    {
        // ���������, ��� ������� ����� 4 �����
        bool isValid = text.Length == 4 && System.Text.RegularExpressions.Regex.IsMatch(text, "^[0-9]+$");
        
        // ����������/������������ ������
        button.interactable = isValid;
    }

    void OnDestroy()
    {
        // ������������ �� ������� ��� ����������� �������
        if (inputField != null)
            inputField.onValueChanged.RemoveListener(CheckInput);
    }
}