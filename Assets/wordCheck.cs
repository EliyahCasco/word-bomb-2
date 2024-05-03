using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class wordCheck : MonoBehaviour
{
    public inputText text;
    List<string> allWords;
    public GameObject timer;
    timer timerScript;
    public GameObject levelSystem;
    levelSystem levelScript;
    public GameObject inputText;
    inputText inputTextScript;
    public AudioSource wrongSoundPlay;

 

    public string wordComplete = "";



    private void Start()
    {
        allWords = readTextFile("Assets/words.txt"); //l�ser ingeom hella min text fil med ordlistan. 
        timerScript = timer.GetComponent<timer>(); 
        levelScript = levelSystem.GetComponent<levelSystem>();
        inputTextScript = inputText.GetComponent<inputText>();
    }


    private void Update()
    {
        checkWord(); 

       
    }
    List<string> readTextFile(string file_path) //h�r g�rs listan med alla ord efter filen har l�sts igenom och string listan f�r v�rderna av filen. 
    {
        // Man �ppnar en stream till en text fil f�r att sedan kunna l�sa av den filen
        StreamReader inp_stm = new StreamReader(file_path);
        //Skapa en lista som man sedan l�gger in alla rader
        List<string> line = new List<string>();
        //L�s av filen tills man har n�tt slutet
        while (!inp_stm.EndOfStream) //Om filens slut inte har n�tts. 
        { 
            string inp_ln = inp_stm.ReadLine(); //l�ser in raden
            line.Add(inp_ln); //l�gger till raden i en lsita
        }

        inp_stm.Close(); //st�nger filen
        return line; //returnar tillbaka listan s� vi kan anv�nda den. 
    }

    public void checkWord()
    {
        if (Input.GetKeyDown(KeyCode.Return)) //om enter �r tryckt
        {
            wordComplete = text.currentText.text; //wordcomplete string f�r v�rdet av texten
            wordComplete = wordComplete.Trim(); //syftet f�r trim �r att ta bort "blank spaces" i stringen. Hade en bug att det var mellanslag efter stringen som inte gick att ta bort.
            bool wordExist = false; 
            for (var i = 0; i < allWords.Count; i++) //g�r igenom ordlistan
            {
                if (wordComplete == allWords[i] && wordComplete.Contains(text.wordText.text)) //om min string finns i ordlistan och stringen inneh�ller texten med startbokst�verna
                {
                    wordExist = true; //boolen blir true
                    allWords.RemoveAt(i); //ordet som blivigt r�tt f�rsvinner ur ordlsitan
                    break;
                }
            }
            if (wordExist) //om boolen �r true
            {
                Debug.Log("True");
                timerScript.currentTime = levelScript.levelTimeChange; //inf�r level scriptet
                levelScript.currentLevel += 1; //g�r upp i level
                inputTextScript.currentText.text = ""; //inut texten blir erased.
                inputTextScript.startLetters();
            }
            else
            {
                Debug.Log("False");
                inputTextScript.currentText.text = string.Empty; //input texten blir erased
                wrongSoundPlay.Play(); //fungerar inte men spelar ett ljud.
            }
        }
    }


}
