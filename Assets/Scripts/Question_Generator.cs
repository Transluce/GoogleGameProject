using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question_Generator : MonoBehaviour {

    // Use this for initialization
    public int a, b, c,d;
    string operatr;
    void Start() {

        putquestion();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    string generate()
    {
        int operationSelector;
        string equation = "";
        operationSelector = Random.Range(1, 4);
       // operationSelector = 4;
        switch(operationSelector)
        {
            case 1:
                operatr = "+";
                a = Random.Range(0, 10);
                b = Random.Range(0, 10);
                c = a + b;
                equation = a.ToString() + operatr + b.ToString();
                break;
            case 2:
                operatr = "-";
                a = Random.Range(0, 10);
                b = Random.Range(0, a);
                c = a - b;
                equation = a.ToString() + operatr + b.ToString();
                break;
            case 3:
                operatr = "x";
                a = Random.Range(0, 10);
                b = Random.Range(0, 10);
                c = a * b;
                equation = a.ToString() + operatr + b.ToString();
                break;
            case 4:
                operatr = "/";
                a = Random.Range(0, 10);
                b = Random.Range(0, 10);
                while ((a % b) != 0)
                {
                    b = Random.Range(0, 10);
                }
                c = a / b;
                equation = a.ToString() + operatr + b.ToString();
                break;
        }
        return equation;
    }
   public void putquestion()
    {
        GameObject question = GameObject.Find("QuestionText");
        GameObject[] answers = new GameObject[4];
        Text[] answers_text = new Text[4];
        d = 0;
        for (int i = 0; i < 4; i++)
        {
            answers[i] = GameObject.Find("Text_" + (i + 1));
            answers_text[i] = answers[i].GetComponent<Text>();
            answers_text[i].text = Random.Range(d, 20).ToString();
            d++;
        }
        Text question_val = question.GetComponent<Text>();
        question_val.text = "What is " + generate();
        question_val.text += "?";
        answers_text[Random.Range(0, 4)].text = c.ToString();
    }
}
