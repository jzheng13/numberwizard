using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

    int guess;
    int min;
    int max;

    // Use this for initialization
    void Start() {
        StartGame();
    }

    // Start game prompt
    void StartGame(){
        min = 1;
        max = 1001;
        guess = 500;
        print("==========================================");
        print("Welcome to Number Wizard!");
        print("Pick a number in your head, but don't tell me.");

        print("The highest number you can pick is " + (max - 1) +
            " and the smallest number you can pick is " + min + ".");

        print("Is the number higher or lower than " + guess + "?");
        print("Press \u2191 for higher, \u2193 for lower and " +
            "\u21b5 for equal.");
    }
    
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Return)) {
            print("I won!");
            // this.enabled = false;
            StartGame();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            PrintQuery();
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            PrintQuery();
        }
        
    }

    // Helper function for getting guess and printing query
    void PrintQuery() {
        guess = (max + min) / 2;
        print("Higher or lower than" + guess + "?");
        print("Press \u2191 for higher, \u2193 for lower and " +
    "\u21b5 for equal.");
    }
}
