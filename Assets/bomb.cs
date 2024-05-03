using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class bomb : MonoBehaviour
{
    public GameObject timer;
    timer script;
    public GameObject levelSystem;
    levelSystem levelScript;
    public GameObject inputText;
    inputText inputScript;
    public Sprite explosion;
    public AudioSource deathSoundPlay;
    bool fine = true;
    public AudioSource deathMusic;
    public GameObject deathScreen;
    public GameObject scoreScript;

    private void Start()
    {
        gameObject.SetActive(true);
        script = timer.GetComponent<timer>();
        inputScript = inputText.GetComponent<inputText>();
    }
    private void Update()
    {
        if (script.currentTime <= 0  && fine) //ändrar bombens sprite när timmer tiden når 0.
        {   
               whenDeath();
        }
    }
    private void changeImage()
    {
        GetComponent<SpriteRenderer>().sprite = explosion; //ändrar objectets spriterenderar till en ny sprite. 
    }

    private IEnumerator deathDelay()
    {
        yield return new WaitForSeconds(2);
        deathScreen.SetActive(true);
    }

    private void whenDeath()
    {
        inputScript.theme1.Stop();
        inputScript.theme2.Stop();
        inputScript.theme3.Stop();
        deathMusic.Play();
        inputText.SetActive(false);
        deathSoundPlay.Play();
        StartCoroutine(deathDelay());
        scoreScript.SetActive(false);

        Debug.Log("Explode bomb");
        changeImage();
        fine = false;


    }


}




