using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int min;
    int max;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        min = 1;
        max = 1000;
        guess = 500;


        Debug.Log("Welcome to number wizard");
        Debug.Log("Please pick a number between " + min + " and " + max);
        Debug.Log("Is your number higher or lower than " + guess + "?");
        Debug.Log("Press Up = higher, or Down = lower, or hit enter = correct");

        max++;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Yayyyyyyyyyyy");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("New guess " + guess);
    }
}
