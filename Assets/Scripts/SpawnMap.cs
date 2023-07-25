using Unity.VisualScripting;
using UnityEngine;

public class SpawnMap : MonoBehaviour
{
    [SerializeField] private GameObject ground;
    [SerializeField] private GameObject mapSpawn;

    private void Start()
    {
        InvokeRepeating("SpawnMaps", 0, 35f);
        mapSpawn.transform.position = new Vector3(0, -8.1f, 1000);
    }

    public void SpawnMaps()
    {
        Instantiate(ground, mapSpawn.transform);
    }


}
