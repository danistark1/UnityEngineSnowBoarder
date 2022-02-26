using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") {
            Debug.Log("You Finished!");
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
