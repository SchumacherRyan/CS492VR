using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(new Vector3(0.0f, 0.5f, 0.0f), Vector3.up, 20* Time.deltaTime);
    }
}
