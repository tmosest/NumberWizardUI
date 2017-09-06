using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	int max = 1000;
	int min = 1;
	int guess = 500;
	int guessCount = 0;
	int maxGussesAllowed = 10;

	public Text text;

	private void _setText(string str) {
		text.text = str;
	}

	private void _intro() {
		string msg = "Welcome to Number Wizard.\n\n" +
			"Pick a number in your head but don't tell me.";
		_setText (msg);
	}

	private void _minMax() {
		int max = 1000;
		int min = 1;
		string msg = "The highest number you can pick is " + max + ".\n\n" +
		             "The lowest number you can pick is " + min + ".";
		_setText (msg);
	}

	private void _gameOver() {
		print ("I won!");
	}

	private void _guess() {
		string msg = "Is the number higher or lower than " + guess + "?\n\n";
		_setText (msg);
		guessCount++;
		if (guessCount >= maxGussesAllowed) {
			Application.LoadLevel ("Win");
		}
	}

	public void guessTooLow() {
		print (guess + " was too low.");
		min = guess;
		_setNewGuess ();
		_guess ();
	}

	public void guessTooHigh() {
		print (guess + " was too high.");
		max = guess;
		_setNewGuess ();
		_guess ();
	}

	public void guessRight() {
		Application.LoadLevel ("Loose");
	}

	private void _newGame() {
		max = 1000;
		min = 1;
		guess = 500;
		guessCount = 0;

		_intro ();
		_minMax ();
		_guess ();
	}

	private void _setNewGuess() {
		guess = (max + min) / 2;
	}

	// Use this for initialization
	void Start () {
		_newGame ();
	}
	
	// Update is called once per frame
	void Update () {
	}
}
