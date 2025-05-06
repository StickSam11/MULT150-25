using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange;
    private bool isGameOver = false;
    private float timer = 0f; // Timer to track time
    private bool timerRunning = false;

    void Update()
    {
        // If all four goals are solved then the game is over
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;

        // Start the timer once the game begins
        if (!isGameOver && !timerRunning)
        {
            timerRunning = true;
        }

        // If the game is still ongoing, update the timer
        if (timerRunning && !isGameOver)
        {
            timer += Time.deltaTime;
        }

        // Check if 'F' key is pressed to restart the game
        if (isGameOver && Input.GetKeyDown(KeyCode.F))
        {
            RestartGame();
        }
    }

    void OnGUI()
    {
        if (isGameOver)
        {
            // Display "Game Over" box
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");

            // Display "Good Job!" label
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, "Good Job!");

            // Display the time taken to win
            Rect timeRect = new Rect(Screen.width / 2 - 50, Screen.height / 2 + 25, 100, 50);
            GUI.Label(timeRect, "Time: " + FormatTime(timer));

            // Display "Press F to Replay" message
            Rect replayRect = new Rect(Screen.width / 2 - 75, Screen.height / 2 + 75, 150, 50);
            GUI.Label(replayRect, "Press F to Replay");
        }
    }

    // Helper method to format time into minutes and seconds
    string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    // Reset the game when 'F' is pressed
    void RestartGame()
    {
        // Reset all goals
        blue.ResetGoal();
        green.ResetGoal();
        red.ResetGoal();
        orange.ResetGoal();

        // Reset timer
        timer = 0f;
        timerRunning = false;

        // Set isGameOver back to false to start the game again
        isGameOver = false;
    }
}
