using Unity.VisualScripting;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    [SerializeField] private GameObject _h_Enemy;
    [SerializeField] private GameObject _h_EnemyL;
    [SerializeField] private GameObject _t_Enemy;
    [SerializeField] private GameObject _pointSpawn;

    

    private void FixedUpdate()
    {
        SpawnTankSpawn();
        SpawnHelicopterSpawn();
        SpawnHelicopterSpawnL();
    }
    

    public void SpawnTank()
    {
        Instantiate(_t_Enemy, _pointSpawn.transform);
    }

    void SpawnTankSpawn()
    {
        if (!GameObject.FindGameObjectWithTag("EnemyTank"))
        {
            Invoke("SpawnTank", 3);
        }
        else
        {
            CancelInvoke("SpawnTank");
        }
    }



    //Helicopter Right
    public void SpawnHelicopter()
    {
        Instantiate(_h_Enemy, _pointSpawn.transform);
    }
    void SpawnHelicopterSpawn()
    {
        if (!GameObject.FindGameObjectWithTag("EnemyHelicopter"))
        {
            Invoke("SpawnHelicopter", 3);
        }
        else
        {
            CancelInvoke("SpawnHelicopter");
        }
    }


    //Helicopter Left
    public void SpawnHelicopterL()
    {
        Instantiate(_h_EnemyL, _pointSpawn.transform);
    }


    void SpawnHelicopterSpawnL()
    {
        if (!GameObject.FindGameObjectWithTag("HelicopterL"))
        {
            Invoke("SpawnHelicopterL", 3);
        }
        else
        {
            CancelInvoke("SpawnHelicopterL");
        }
    }
}