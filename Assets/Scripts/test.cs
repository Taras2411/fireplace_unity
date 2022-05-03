using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class test : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        var testList = ResourcesFacory.CreateAllResources();
        foreach(var item in testList)
        {
            Debug.Log(item.Name + " " + item.Amount + " " + item.MaxAmount + " " + item.pathToIconSprite + " " + item.GetType());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
