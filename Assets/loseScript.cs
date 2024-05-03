using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loseScript : MonoBehaviour
{
    public GameObject timer;
    timer timerScript;

    private void Start()
    {
        timerScript = timer.GetComponent<timer>();
    }




    public void checkDeath()
    {
        if(timerScript.currentTime == 0)
        {
            Debug.Log("dead");
        }
    }
}
