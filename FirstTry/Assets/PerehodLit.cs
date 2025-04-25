using UnityEngine;
using UnityEngine.SceneManagement;

public class PerehodLit : MonoBehaviour
{
    [SerializeField] private KeyCode interactKey = KeyCode.E; // ������� �������������� (����� ��������)
    [SerializeField] private GameObject hintUI; // ��������� "����� E" (�����������)
    
    private bool playerInRange = false;

    // �������� ����� � �������
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            if (hintUI != null) 
                hintUI.SetActive(true); // ���������� ���������
        }
    }

    // �������� ������ �� ��������
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            if (hintUI != null) 
                hintUI.SetActive(false); // �������� ���������
        }
    }

    // �������� ������� �������
    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(interactKey))
        {
            Transition();
        }
    }

    // ����� �������� �� �����
    public void Transition()
    {
        Debug.Log("������� �� ����� � �������� 17");
        SceneManager.LoadScene(20); // �������� ����� �� �������
    }
}