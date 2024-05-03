using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    public Text loadingText;

 public void loadGame(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while(!operation.isDone)
        {
            float loadProgress = Mathf.Clamp01(operation.progress / .9f);

            slider.value = loadProgress;
            loadingText.text = loadProgress * 100f + "%";

            yield return null;
        }
    }


}
