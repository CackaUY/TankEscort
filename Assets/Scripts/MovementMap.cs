using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementMap : MonoBehaviour
{
    private float _speedMap = 1f;
    void FixedUpdate()
    {
        transform.Translate(0, _speedMap * Time.deltaTime, 0);
        
        if (transform.position.y >= 11f)
        {
            Destroy(gameObject);
        }
    }
}
