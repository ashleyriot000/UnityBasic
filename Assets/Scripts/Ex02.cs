using UnityEngine;
using UnityEngine.UI;

public class Ex02 : MonoBehaviour
{
    //퀴즈버튼, 인풋필드, 엔터버튼 게임오브젝트 변수 필요.
    public GameObject quizObj;
    public GameObject inputObj;
    public GameObject enterObj;
    public InputField inputField;
    public Text resultText;

    public int quizValue;

    private void Start()
    {
        quizObj.SetActive(true);
        inputObj.SetActive(false);
        enterObj.SetActive(false);
    }

    public void EnterButton()
    {
        if(int.TryParse(inputField.text, out int result))
        {
            if(result == quizValue)
            {
                resultText.text = "정답입니다.";
                quizObj.SetActive(true);
                inputObj.SetActive(false);
                enterObj.SetActive(false);
            }
            else if(result < quizValue)
            {
                resultText.text = "업";
            }
            else if(result > quizValue)
            {
                resultText.text = "다운";
            }
        }
    }

    public void NewQuiz()
    {
        quizValue = Random.Range(1, 1001);
        quizObj.SetActive(false);
        enterObj.SetActive(true);
        inputObj.SetActive(true);        
    }
}
