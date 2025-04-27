using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTimer : MonoBehaviour
{
    public GameObject timeDisplay01;
    private bool isTakingTime=false;
    public int theSeconds = 150;
    public static int theSecondsStasic ;

    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Update()
    {
        theSecondsStasic = theSeconds;
        if (isTakingTime == false) {
            StartCoroutine(SubtractSecond());
        }
        
    }

    private IEnumerator SubtractSecond() {
        isTakingTime = true;
        theSeconds -= 1;
        timeDisplay01.GetComponent<Text>().text = "" +theSeconds;
        yield return new WaitForSeconds(1);
        isTakingTime = false;
    }
}
