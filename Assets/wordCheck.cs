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
        allWords = readTextFile("Assets/words.txt"); //läser ingeom hella min text fil med ordlistan. 
        timerScript = timer.GetComponent<timer>(); 
        levelScript = levelSystem.GetComponent<levelSystem>();
        inputTextScript = inputText.GetComponent<inputText>();
    }


    private void Update()
    {
        checkWord(); 

       
    }
    List<string> readTextFile(string file_path) //här görs listan med alla ord efter filen har lästs igenom och string listan får värderna av filen. 
    {
        // Man öppnar en stream till en text fil för att sedan kunna läsa av den filen
        StreamReader inp_stm = new StreamReader(file_path);
        //Skapa en lista som man sedan lägger in alla rader
        List<string> line = new List<string>();
        //Läs av filen tills man har nått slutet
        while (!inp_stm.EndOfStream) //Om filens slut inte har nåtts. 
        { 
            string inp_ln = inp_stm.ReadLine(); //läser in raden
            line.Add(inp_ln); //lägger till raden i en lsita
        }

        inp_stm.Close(); //stänger filen
        return line; //returnar tillbaka listan så vi kan använda den. 
    }

    public void checkWord()
    {
        if (Input.GetKeyDown(KeyCode.Return)) //om enter är tryckt
        {
            wordComplete = text.currentText.text; //wordcomplete string får värdet av texten
            wordComplete = wordComplete.Trim(); //syftet för trim är att ta bort "blank spaces" i stringen. Hade en bug att det var mellanslag efter stringen som inte gick att ta bort.
            bool wordExist = false; 
            for (var i = 0; i < allWords.Count; i++) //går igenom ordlistan
            {
                if (wordComplete == allWords[i] && wordComplete.Contains(text.wordText.text)) //om min string finns i ordlistan och stringen innehåller texten med startbokstäverna
                {
                    wordExist = true; //boolen blir true
                    allWords.RemoveAt(i); //ordet som blivigt rätt försvinner ur ordlsitan
                    break;
                }
            }
            if (wordExist) //om boolen är true
            {
                Debug.Log("True");
                timerScript.currentTime = levelScript.levelTimeChange; //inför level scriptet
                levelScript.currentLevel += 1; //går upp i level
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
