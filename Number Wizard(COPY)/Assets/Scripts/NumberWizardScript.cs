using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardScript : MonoBehaviour {


    int min = 1;
    int max = 1000;
    int guess = 500;

    // Use this for initialization
    void Start () {
        print("Welcome to Number Wizard!");
        print("Pick a number between 1 and 1000!");


        print("Is the number higher, lower or equal to " + guess + "?");
        print("Higher: UP arrow, Lower: DOWN arrow, Equal: ENTER");
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("up"))
        {
            print("Up Arrow pressed!");
            min = guess;
            guess = (min + max) / 2;
            print("Is the number higher, lower or equal to " + guess + "?");
            print("Higher: UP arrow, Lower: DOWN arrow, Equal: ENTER");
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        // if(Input.GetKeyDown("down"))
        {
            print("Down Arrow pressed!");
            max = guess;
            guess = (min + max) / 2;
            print("Is the number higher, lower or equal to " + guess + "?");
            print("Higher: UP arrow, Lower: DOWN arrow, Equal: ENTER");
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Enter Key pressed!");
            print("I won!");
        }

    }
}
