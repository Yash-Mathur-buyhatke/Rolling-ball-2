using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animator ballAnimation = GameObject.Find("Ball").GetComponent<Animator>();
        ballAnimation.speed = 10;
        // Debug.Log(ballAnimation.speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
