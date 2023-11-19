using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Listens : MonoBehaviour
{

    public GameObject pauseMenuPanel;
    public Button resumeButton;
    private bool paused = false;
    public AudioSource audiosource;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                UnPauseGame();
            }
            else
            {
                PauseGame();
            }
            //Time.timeScale = 0;
            //MenuController.LoadSceneForSavedGame = false;
            //SceneManager.LoadScene(0, LoadSceneMode.Additive);
            //Cursor.visible = true;
        }
    }

    public void UnPauseGame()
    {
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
        resumeButton.Select();
        audiosource.UnPause();
    }
    void PauseGame()
    {
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
        audiosource.Pause();
    }
    public void LoadMenu()
    {
        Debug.Log("Loading Game...");
    }
    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        //added the timescale code because the game would always stay paused after going back into it from the main menu
        Time.timeScale = 1f;
    }


}
