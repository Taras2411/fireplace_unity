using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{   

    // Start is called before the first frame update
    
    //get prefabs from dirrectory /Prefabs/Firewood
    public GameObject[] firewoodPrefab;


    void Start()
    {
        //get the firewood prefab
        firewoodPrefab = Resources.LoadAll<GameObject>("Prefabs/Firewood");
        //get the firewood prefab

        
    }

    // Update is called once per frame
    void Update()
    {
        //print name of firewood prefabs
        foreach (GameObject firewood in firewoodPrefab)
        {
            print(firewood.name);
        }
    }
}
