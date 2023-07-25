using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    [SerializeField] private GameObject _t_Enemy;

    private void Update()
    {
        if (_t_Enemy.IsDestroyed())
        {
            _t_Enemy.SetActive(true);
            Invoke("SpawnTank", 3);
        }
    }

    public void SpawnTank()
    {
        Instantiate(_t_Enemy, transform);
    }
}
