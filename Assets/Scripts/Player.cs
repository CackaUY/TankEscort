using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private int _health = 10;
    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _tankPlayer;
    [SerializeField] private GameObject _destroyPlayer;
    [SerializeField] private GameObject _sheld;
    [SerializeField] private Text _hp;
    private bool _isSheld = false;
    private float timers = 1f;
    private float _timerSheld = 3f;

    private void Update()
    {
        DestroyPlayer();
        Couldown();
        MovePlayer();
        _hp.text = _health.ToString();
    }

    public void SheldTank()
    {
        StartCoroutine("setIsSheld");
        _sheld.SetActive(false);
        _timerSheld = 3;
    }

    void Couldown()
    {
        _timerSheld -= Time.deltaTime;
        if (_timerSheld <= 0)
        {
            _sheld.SetActive(true);
        }
    }

    private IEnumerator setIsSheld()
    {
        _isSheld = true;
        yield return new WaitForSeconds(1);
        _isSheld = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Rocket") && !_isSheld)
        {
            _health--;
        }
    }

    void DestroyPlayer()
    {
        if (_health <= 0)
        {
            timers -= Time.deltaTime;
            _tankPlayer.SetActive(false);
            _animator.Play("Explosion");
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

    void MovePlayer()
    {
        if(transform.position.y >= 0.62f)
        {
            transform.Translate(0, 0.01f, 0);
        }else
        {
            transform.Translate(0, 0, 0);
        }
    }
}
