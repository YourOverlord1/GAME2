using UnityEngine;
using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;

    public void Answer()
    {
        if(isCorrect)
        {
            Debug.Log("���������� �����!");
            quizManager.correct();
        }
        else
        {
            Debug.Log("������������ �����!");
            quizManager.wrong();
        }
    }
}