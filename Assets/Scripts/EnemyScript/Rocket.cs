using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] Animator _animator;
    Transform _target;
    private float _speed = 0.2f;

    private void Start()
    {
        _target = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,_target.position, _speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            _animator.Play("Explosion");
            StartCoroutine("DelayDestroy");
        }
    }

    private IEnumerator DelayDestroy()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }
}
