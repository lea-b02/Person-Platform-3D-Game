using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{
    //les ecriture
    public GameObject youFell;

    //l'audio
    public GameObject levelAudio;

    //le fond noir fondu noir 
    public GameObject fadeOut;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(YouFellOff());
        }
    }

    IEnumerator YouFellOff() { 
    
        youFell.SetActive(true);
        levelAudio.SetActive(false);
        
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        
        yield return new WaitForSeconds(1);
        GlobalScore.current = 0;
        SceneManager.LoadScene(RedirectToLevel.redirectToLevel);
    }
}
