using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuFonction : MonoBehaviour
{
    public AudioSource boutonPress;
    public int bestScore;
    public GameObject bestScoreDisplay;
    private void Start()
    {
        bestScore = PlayerPrefs.GetInt("LevelScore");
        bestScoreDisplay.GetComponent<Text>().text = "  Best: " + bestScore.ToString();
    }

    public void playGame(){ 
        boutonPress.Play();
        RedirectToLevel.redirectToLevel = 3;
        SceneManager.LoadScene(2);
    
    }

    public void QuitGame() { 
        Application.Quit();
    }

    public void CreditGame()
    {
        boutonPress.Play();
        SceneManager.LoadScene(5);
    }

    public void Reset()
    {
        //int count = PlayerPrefs.GetInt("LevelScore");
        //Debug.Log("BestScore avent modificatoin:" + bestScore.ToString() + " Count avent modificatoin:" + count.ToString()  );
        PlayerPrefs.SetInt("LevelScore", 0);
        //count = PlayerPrefs.GetInt("LevelScore");
        //Debug.Log("BestScore avent modificatoin:" + bestScore.ToString()+ " Count apres modificatoin:" + count.ToString());
        
        bestScoreDisplay.GetComponent<Text>().text = "  Best: 0";
    }
}
