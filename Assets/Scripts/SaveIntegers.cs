using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveIntegers : MonoBehaviour
{
    public GameObject targetFlow;
    public string[] intVariables;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void saveIntVariablesFromFungus()
    {
        for (int i = 0; i < intVariables.Length; i++)
        {
            int intValue = targetFlow.GetComponent<Fungus.Flowchart>().GetIntegerVariable(intVariables[i]);
            Debug.Log(intVariables[i]);
            Debug.Log(intValue);

            PlayerPrefs.SetInt(intVariables[i], intValue);
            PlayerPrefs.Save();
        }
    }
}
