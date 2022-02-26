using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surface : MonoBehaviour
{
    SurfaceEffector2D se2D;
    // Start is called before the first frame update
    void Start()
    {
         se2D = GetComponent<SurfaceEffector2D>();
    }

    // Update is called once per frame
       // Update is called once per frame
    void Update()
    {
        // if (Input.GetKey(KeyCode.Space)) {
        //     se2D.speedVariation = 7;
        // }
    }
}
