using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnMap : MonoBehaviour
{
    [SerializeField] private GameObject ground;
    private Vector2 posMap = new Vector2(0, 0);

    private void Start()
    {
        Instantiate(ground, posMap, Quaternion.identity);
        InvokeRepeating("SpawnMaps", 0, 22);
    }

    public void SpawnMaps()
    {
        Vector2 posMap = new Vector2(0, transform.position.y);
        Instantiate(ground, transform.position, Quaternion.identity);
    }


}
