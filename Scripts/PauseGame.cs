using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PauseGame : MonoBehaviour
{
    private bool gamePause = false;
    public AudioSource levelAudio;
    public AudioSource levelPause;
    public GameObject pauseMenu;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Cancel")) {
            if (!gamePause)
            {
                pauseMenu.SetActive(true);
                gamePause = true;
                Time.timeScale = 0;
                Cursor.visible = true;
                levelAudio.Pause();
                levelPause.Play();

            }
            else {
                pauseMenu.SetActive(false);
                levelAudio.UnPause();
                gamePause = false;
                Cursor.visible = false;
                Time.timeScale = 1;
            }
            
        }
    }

    // on retourne joue
    //public void ResumeGame() {

    //    pauseMenu.SetActive(false);
    //    levelAudio.UnPause();
    //    gamePause = false;
    //    Cursor.visible = false;
    //    Time.timeScale = 1;

    //}


    // on recommence le niveau ou quit le jeux pour allez aux menu pricipal
    //public void RestartLevel()
    //{

    //    pauseMenu.SetActive(false);
    //    levelAudio.UnPause();
    //    gamePause = false;
    //    Cursor.visible = false;
    //    Time.timeScale = 1;
    //    SceneManager.LoadScene(2);

    //}

    //public void QuitToMenu()
    //{

    //    pauseMenu.SetActive(false);
    //    levelAudio.UnPause();
    //    gamePause = false;
    //    Cursor.visible = false;
    //    Time.timeScale = 1;
    //    SceneManager.LoadScene(1);

    //}

    public void OnButtonClick()
    {
        string clickedButton = EventSystem.current.currentSelectedGameObject.name;
       // Debug.Log("Button clicked: " + clickedButton);
        if (clickedButton == "ButtonResume") {
           
            pauseMenu.SetActive(false);
            levelAudio.UnPause();
            gamePause = false;
            Cursor.visible = false;
            Time.timeScale = 1;
            return;

        }

        pauseMenu.SetActive(false);
        levelAudio.UnPause();
        gamePause = false;
        Cursor.visible = true;
        Time.timeScale = 1;

        if (clickedButton == "ButtonRestar")
        {

            // Récupérer la scène actuelle AVANT de changer
            string lastSceneName = SceneManager.GetActiveScene().name;
            int lastSceneIndex = SceneManager.GetActiveScene().buildIndex;

            RedirectToLevel.redirectToLevel = lastSceneIndex;

            // Ensuite charger la nouvelle scène
            SceneManager.LoadScene(2);
        }
        else if (clickedButton == "ButtonQuit")
        {
            
            SceneManager.LoadScene(1);
        }
    }
}
