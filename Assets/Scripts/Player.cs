using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int _health = 2;
    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _tankPlayer;
    [SerializeField] private GameObject _destroyPlayer;
    private float timers = 1f;

    private void Update()
    {
        DestroyPlayer();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Rocket"))
        {
            Debug.Log("BAXX");
            _health--;
        }
    }

    void DestroyPlayer()
    {
        if (_health <= 0)
        {
            timers -= Time.deltaTime;
            _tankPlayer.SetActive(false);
            if (timers > 0)
            {
                _destroyPlayer.SetActive(true);
                _destroyPlayer.transform.Translate(0, -0.1f * Time.deltaTime, 0);
            }
            else
            {
                _destroyPlayer.SetActive(false);
                Destroy(_player);
                SceneManager.LoadScene(2);
            }
        }
    }
}
