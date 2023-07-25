using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEnemyAndMove : MonoBehaviour
{
    
    void Update()
    {
        if(transform.position.y <= -0.3f)
        {
            transform.Translate(0, 0.01f, 0);
        }
        else
        {
            transform.Translate(0, 0, 0);
        }
    }

}
