using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground") {
            Debug.Log("Ouch, hit my head!");
        } 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
