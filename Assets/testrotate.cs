using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testrotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Zusatzfunktion
    void Update()
    {
        // Rotate the object around its local X axis at 1 degree per second
        transform.Rotate(210*Time.deltaTime, 0, 0);

        // ...also rotate around the World's Y axis
        transform.Rotate(0, 200*Time.deltaTime, 0, Space.World);
    }
}
