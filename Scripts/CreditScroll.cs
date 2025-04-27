using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditScroll : MonoBehaviour
{
    public GameObject creditsRun;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(RollCredits());
    }

    // Update is called once per frame
    IEnumerator RollCredits()
    {
        yield return new WaitForSeconds(0.5f);
        creditsRun.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }
}
