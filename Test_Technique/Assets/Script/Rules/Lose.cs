using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lose : MonoBehaviour
{
    
    [SerializeField]
    private Text timerText;

    private float timeLeft;

    public GameObject loseScreen;
    void Awake()
    {
        loseScreen.SetActive(false);
        timeLeft = 30f;
        StartCoroutine(Timer());
    }

    void OnDisable() => StopCoroutine(Timer());


    private void OnDestroy() => StopCoroutine(Timer());


    IEnumerator Timer()
    {
        while(timeLeft > 0)
        {
            timeLeft--;
            yield return new WaitForSeconds(1f);
            timerText.text = "00 : " + timeLeft;
        }
        if(timeLeft <= 0)
        {
            loseScreen.SetActive(true);
        }
    }
}
