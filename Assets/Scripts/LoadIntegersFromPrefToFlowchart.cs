using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadIntegersFromPrefToFlowchart : MonoBehaviour
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

    public void loadIntegers()
    {
        for (int i = 0; i < intVariables.Length; i++)
        {
            int value = PlayerPrefs.GetInt(intVariables[i], -1);

            Debug.Log(intVariables[i]);
            Debug.Log(value);

            targetFlow.GetComponent<Fungus.Flowchart>().SetIntegerVariable(intVariables[i], value);
            
        }
    }
}
