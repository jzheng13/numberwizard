using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    int guess;
    int min;
    int max;
    int maxGuesses = 10;

    public Text text;

    void Start() {
        StartGame();
    }

    void StartGame() {
        min = 1;
        max = 1000;
        guess = Random.Range(min, max + 1);
        text.text = guess.ToString();
    }

    public void GuessHigher() {
        min = guess;
        NextGuess();
    }

    public void GuessLower() {
        max = guess;
        NextGuess();
    }

    void NextGuess() {
        guess = Random.Range(min, max + 1);
        maxGuesses--;
        if (maxGuesses <= 0) {
            SceneManager.LoadScene("Lose");
        }
        text.text = guess.ToString();
    }
}
