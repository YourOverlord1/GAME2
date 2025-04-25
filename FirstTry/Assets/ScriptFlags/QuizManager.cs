using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class QuestionAndAnswerFlags
{
    public Sprite FlagSprite; // Изображение флага
    public string[] Answers; // Варианты ответов
    public int CorrectAnswer; // Номер правильного ответа (1-based)
}

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswerFlags> QnA;
    public GameObject[] options; // Кнопки с вариантами ответов
    public int currentQuestion;

    public GameObject Quizpanel;
    public GameObject GoPanel;

    public Image FlagImage; // UI Image для отображения флага
    public Text ScoreTxt;

    int totalQuestions = 0;
    public int score;

    private void Start()
    {
        totalQuestions = QnA.Count;
        GoPanel.SetActive(false);
        generateQuestion();
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameOver()
    {
        Quizpanel.SetActive(false);
        GoPanel.SetActive(true);
        //ScoreTxt.text = score + "/" + totalQuestions;
    }

    public void correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    void SetAnswer()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);
            FlagImage.sprite = QnA[currentQuestion].FlagSprite;
            SetAnswer();
        }
        else
        {
            Debug.Log("Вопросы закончились!");
            GameOver();
        }
    }
}