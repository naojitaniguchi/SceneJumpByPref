using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchByPref : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startFromStart()
    {
        PlayerPrefs.DeleteAll();
    }

    public void startFromSavedScene()
    {
        int sceneIndex = -1;

        if (PlayerPrefs.HasKey("LastSceneIndex"))
        {
            // 存在する
            sceneIndex = PlayerPrefs.GetInt("LastSceneIndex", 0);

            Debug.Log(sceneIndex);
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
