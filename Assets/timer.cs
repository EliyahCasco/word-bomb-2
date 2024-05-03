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
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime -= Time.deltaTime; //algortythm för att räkna ned tiden, för att displaya nedräkningen på skärmen så måste man dra in tm pro i unity.

        if (isZero && ((countDown && currentTime <= notNegative || (!countDown && currentTime >= notNegative))))
        {
            currentTime = notNegative; //kollar om timer har nått 0 för att inte räkna ned till -


        }
        timerCountDownText.text = currentTime.ToString("0"); //stannar tiden på 0
    }
}
