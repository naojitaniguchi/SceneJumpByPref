using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveFlags : MonoBehaviour
{
    public GameObject targetFlow;
    public string[] boolFlags;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void saveFlagsFromFungus()
    {
        for (int i = 0; i < boolFlags.Length; i++)
        {
            bool flag = targetFlow.GetComponent<Fungus.Flowchart>().GetBooleanVariable(boolFlags[i]);
            Debug.Log(boolFlags[i]);
            Debug.Log(flag);

            string prefValue = "False";
            if (flag)
            {
                prefValue = "True";
            }
            PlayerPrefs.SetString(boolFlags[i], prefValue);
            PlayerPrefs.Save();
        }
    }
}
