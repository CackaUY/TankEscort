using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class MovementMap : MonoBehaviour
{
    private float _speedMap = 0.1f;
    void Update()
    {
        transform.Translate(0, _speedMap * Time.deltaTime, 0);
        
        if (transform.position.y >= 3f)
        {
            Destroy(gameObject);
        }
    } 
}
