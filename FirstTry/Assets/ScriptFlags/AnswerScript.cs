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
            Debug.Log("Правильный ответ!");
            quizManager.correct();
        }
        else
        {
            Debug.Log("Неправильный ответ!");
            quizManager.wrong();
        }
    }
}