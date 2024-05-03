using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{

   
    [SerializeField]
    public TextMeshProUGUI timerCountDownText;

    public float currentTime;
    public bool countDown = true;

    public bool isZero = true;
    public float notNegative;

    public GameObject levelSystem;
    levelSystem levelScript;

    void Start()
    {
        levelScript = levelSystem.GetComponent<levelSystem>();
    }

    void Update()
    {
        timerCountDown();
    }

    public void timerCountDown()
    {
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime -= Time.deltaTime; //algortythm f�r att r�kna ned tiden, f�r att displaya nedr�kningen p� sk�rmen s� m�ste man dra in tm pro i unity.

        if (isZero && ((countDown && currentTime <= notNegative || (!countDown && currentTime >= notNegative))))
        {
            currentTime = notNegative; //kollar om timer har n�tt 0 f�r att inte r�kna ned till -


        }
        timerCountDownText.text = currentTime.ToString("0"); //stannar tiden p� 0
    }
}
