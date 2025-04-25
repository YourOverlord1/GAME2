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
        // ���������, ��� ���� ������� ������ �� ���� � �� ���������� ������ 4
        if (System.Text.RegularExpressions.Regex.IsMatch(newValue, "^[0-9]+$") && newValue.Length > 4)
        {
            // ������� ��� �������
            inputField.text = "";
            
            // �����������: ����� ������� ��������� ������������
            Debug.Log("������������ ���������� ���� - 4. ���� ������.");
        }
    }

    void OnDestroy()
    {
        // �� �������� ���������� �� ������� ��� ����������� �������
        if (inputField != null)
        {
            inputField.onValueChanged.RemoveListener(OnValueChanged);
        }
    }
}