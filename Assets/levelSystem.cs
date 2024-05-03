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
        if (currentLevel <= 5)  //en algorythm för att ändra min timers start tid på grund av vilken level man är på eller hur många rätt man har
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




