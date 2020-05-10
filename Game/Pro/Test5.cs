using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test5 : MonoBehaviour
{
    // Start is called before the first frame update
    int SaveTest = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            SaveTest++;
        }
        
        Debug.Log("Test5>Update::SaveTest::"+ SaveTest);
    }
}
