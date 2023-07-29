using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class RotateHuman : MonoBehaviour
{
    public Transform target;
    //private float _speedRotation = 5f;

    
    void Update()
    {
        transform.LookAt(target);
        //Vector3 direction = (target.position - transform.position).normalized;
        //Quaternion lookRotation = Quaternion.LookRotation(new Vector3(0, 0, direction.z));
        //transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * _speedRotation);
    }
}
