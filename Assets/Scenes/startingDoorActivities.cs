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

    void OnTriggerEnter(Collider other){
        Debug.Log("Entered in Door!");
    }

    void OnTriggerExit(Collider other){
        Debug.Log("Exitted from the Door!");
    }
}
