using UnityEngine;

public class SpawnMap : MonoBehaviour
{
    [SerializeField] private GameObject _ground;
    [SerializeField] private GameObject _mapSpawn;


    private void Start()
    {
        InvokeRepeating("SpawnMaps", 0, 80);
    }

    public void SpawnMaps()
    {
        Instantiate(_ground, _mapSpawn.transform);
    }

}
