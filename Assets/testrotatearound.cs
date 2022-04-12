using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testrotatearound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public Transform objectToOrbit;
    
    void Update()
    {
        transform.RotateAround(objectToOrbit.position, Vector3.up, 100 * Time.deltaTime);
    }
}
