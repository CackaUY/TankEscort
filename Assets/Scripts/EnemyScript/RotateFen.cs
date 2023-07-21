using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFen : MonoBehaviour
{
    

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, 0, 3f);
    }
}
