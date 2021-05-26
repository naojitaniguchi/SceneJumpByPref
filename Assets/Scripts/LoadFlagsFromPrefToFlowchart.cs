using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadFlagsFromPrefToFlowchart : MonoBehaviour
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

    public void loadFlags()
    {
        for (int i = 0; i < boolFlags.Length; i++)
        {
            string flag = PlayerPrefs.GetString(boolFlags[i], "False");
            if ( flag == "True")
            {
                targetFlow.GetComponent<Fungus.Flowchart>().SetBooleanVariable(boolFlags[i], true);
            }
            else
            {
                targetFlow.GetComponent<Fungus.Flowchart>().SetBooleanVariable(boolFlags[i], true);
            }
        }
    }
}
