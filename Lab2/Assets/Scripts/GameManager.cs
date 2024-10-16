using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _score = 0;
    public GameObject ballPrefab; // Reference to the ball prefab
    public Transform ballSpawnPoint; // Where the new ball will be spawned

    private void Start()
    {
        // Lock and hide the cursor at the start of the game
        //LockCursor();
    }

    private void Update()
    {
        // Check if the player presses the 'Q' key to quit
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
        }
    }

    public void IncreaseScore()
    {
        _score++;
        // Notify the ScoreManager to update the UI
        FindObjectOfType<ScoreManager>().UpdateScoreUI(_score);

        SpawnNewBall();
    }

    private void SpawnNewBall()
    {
        if (ballPrefab != null && ballSpawnPoint != null)
        {
            Instantiate(ballPrefab, ballSpawnPoint.position, ballSpawnPoint.rotation);
        }
        else
        {
            Debug.LogError("Ball prefab or spawn point is not set!");
        }
    }

    public int GetScore()
    {
        return _score;
    }

    public void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;  // Locks the cursor to the center of the screen
        Cursor.visible = false;                    // Hides the cursor
    }

    public void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;    // Unlocks the cursor
        Cursor.visible = true;                     // Makes the cursor visible
    }
    private void QuitGame()
    {
        // For testing in Editor
        Debug.Log("Quitting the game...");

        // Quit the game (works in built versions, but not in Editor)
        Application.Quit();

        // Stop play mode if in editor
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
