using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelSystem : MonoBehaviour
{
    public int currentLevel = 1;
    public int levelTimeChange;



    void Start()
    {

    }

   
    void Update()
    {
        levelTime();   
    }

    public void levelTime()
    {
        if (currentLevel <= 5)  //en algorythm f�r att �ndra min timers start tid p� grund av vilken level man �r p� eller hur m�nga r�tt man har
        {
            levelTimeChange = 30;

        }
        if (currentLevel >= 5) 
        {
            levelTimeChange = 20;

        }
        if (currentLevel >= 10)
        {
            levelTimeChange = 15;

        }
        if (currentLevel >= 15)
        {
            levelTimeChange = 10;

        }
        if (currentLevel >= 20)
        {
            levelTimeChange = 5;
        }

    }
}




