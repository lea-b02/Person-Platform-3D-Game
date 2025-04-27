using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FinishLevel : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelComplete;

    public GameObject levelTimer;

    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;

    public int timeCount;
    public int scoreCount;
    public int totalScoreCount;

    public GameObject blockerUnityChan;

    public GameObject fadeOut;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            StartCoroutine(CalculetScore());

        }
    }

    IEnumerator CalculetScore()
    {
        GetComponent<BoxCollider>().enabled = false;
        blockerUnityChan.SetActive(true);
        blockerUnityChan.transform.parent = null;


        timeCount = GlobalTimer.theSecondsStasic * 100;
        timeLeft.GetComponent<Text>().text ="Time Left: " + GlobalTimer.theSecondsStasic.ToString() + " x 100";
        scoreCount = GlobalScore.current;
        theScore.GetComponent<Text>().text = "Score: " + scoreCount.ToString() ;
        totalScoreCount = scoreCount + timeCount;
        totalScore.GetComponent<Text>().text = "Total Score: " + totalScoreCount.ToString() ;
        PlayerPrefs.SetInt("LevelScore", totalScoreCount);

        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();

        timeLeft.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        theScore.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        // Récupérer la scène actuelle AVANT de changer
        string lastSceneName = SceneManager.GetActiveScene().name;
        int lastSceneIndex = SceneManager.GetActiveScene().buildIndex;

        RedirectToLevel.redirectToLevel = lastSceneIndex+1;

        SceneManager.LoadScene(RedirectToLevel.redirectToLevel);

    }

}
