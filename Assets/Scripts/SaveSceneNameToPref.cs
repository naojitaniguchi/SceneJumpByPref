using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveSceneNameToPref : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            saveSceneName();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            clearPref();
        }
    }

    public void saveSceneName()
    {
        string scenePath = SceneManager.GetActiveScene().path;
        string sceneName = SceneManager.GetActiveScene().name;
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(scenePath);
        Debug.Log(sceneName);
        Debug.Log(sceneIndex);

        // SceneManager.GetSceneByBuildIndex(sceneIndex).name;

        
        PlayerPrefs.SetInt("LastSceneIndex", sceneIndex);
        PlayerPrefs.Save();
    }

    public void clearPref()
    {
        PlayerPrefs.DeleteAll();
    }
}
