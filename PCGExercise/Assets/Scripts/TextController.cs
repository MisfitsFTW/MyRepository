using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {


    public Text myQuestion;
    public InputField myField;
    int num1 = 0;
    int num2 = 0;

    //The random class found in system library
    System.Random rand = new System.Random();
    //The random class found in the UnityEngine library
    Random unityRand = new Random();
    // Use this for initialization
    void Start () {
        myQuestion.text = "What is 2*2";
	}
	
	// Update is called once per frame
	void Update () {
       
	}
    public void GetAnswer()
    {
        string answer = " ";
        answer = myField.text;

        if (answer == "4")
        {
            print("correct answer");
        }
        else
        {
            print("wrong aswer");
        }
    }
}
