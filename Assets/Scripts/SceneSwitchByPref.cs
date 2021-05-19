using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchByPref : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int sceneIndex = -1;

        if (PlayerPrefs.HasKey("LastSceneIndex"))
        {
            // 存在する
            sceneIndex = PlayerPrefs.GetInt("LastSceneIndex", 0);

            Debug.Log(sceneIndex);
            SceneManager.LoadScene(sceneIndex);
        }
        else
        {
            // 存在しない
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
