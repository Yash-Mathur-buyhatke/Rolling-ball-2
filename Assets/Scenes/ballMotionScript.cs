using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMotionScript : MonoBehaviour
{
    
    float moveSpeed = 10f;
    [SerializeField] float xValue = -172.5f;
    [SerializeField] float zValue = 86.7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move front
        if(Input.GetKey(KeyCode.UpArrow)){
            zValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
            xValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
            transform.Translate(xValue,0f,zValue);
        
        }
        // Move down
        if(Input.GetKey(KeyCode.DownArrow)){
            zValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
            xValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
            transform.Translate(xValue,0f,-zValue);
        
        }
        // Move right
        if(Input.GetKey(KeyCode.RightArrow)){
            zValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
            xValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
            transform.Translate(-xValue,0f,-zValue);
        
        }
        // Move left
        if(Input.GetKey(KeyCode.LeftArrow)){
            zValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
            xValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
            transform.Translate(-xValue,0f,-zValue);
        
        }
        
    
    }
}
