using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startingDoorActivities : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onTriggerEnter(Collider other){
        Debug.Log("Entered in Door!");
    }

    void onTriggerExit(Collider other){
        Debug.Log("Exitted from the Door!");
    }
}
