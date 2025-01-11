using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    public Button pauseButton;
    public GameObject pauseCanvas;
    private bool isPaused;
    void Start()
    {
        pauseButton.onClick.AddListener(OnButtonPress);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isPaused)
            {
                ResumeGame();

            }
            else
            {
                PauseGame();
            }
        }
    }
    void OnButtonPress()
    {
        if (isPaused)
        {
            ResumeGame();

        }
        else
        {
            PauseGame();
        }

    }
    void PauseGame()
    {
        pauseCanvas.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    void ResumeGame()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1f;
        isPaused=false;
    }

}
