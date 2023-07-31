using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheld : MonoBehaviour
{
    [SerializeField] private GameObject _rocket;
    [SerializeField] private GameObject _sheld;
    private float _timer = 3f;

    

    private void Update()
    {
        Couldown();
    }

    public void SheldTank()
    {
        Destroy(_rocket.gameObject);
        _sheld.SetActive(false);
        _timer = 3f;
    }

    void Couldown()
    {
        _timer -= Time.deltaTime;
        if(_timer <= 0)
        {
            _sheld.SetActive(true);
        }
    }
    
}
