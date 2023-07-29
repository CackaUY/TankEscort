using UnityEngine;

public class EnemyHelicopter : MonoBehaviour
{

    private int health = 8;
    private float timers = 3f;
    [SerializeField] GameObject _enemyHelicopter;
    [SerializeField] GameObject _bodyHelicopter;
    [SerializeField] GameObject _enemyHelicopterDestroy;
    [SerializeField] Animator _animator;

    public void OnTouchAttack()
    {
        health--;
        _animator.Play("Explosion");
    }
    
    private void Update()
    {
        if (transform.position.y <= -0.8f)
        {
            transform.Translate(0, 0.01f, 0);
        }
        else
        {
            transform.Translate(0, 0, 0);
        }
        if (health <= 0)
        {
            timers -= Time.deltaTime;
            _bodyHelicopter.SetActive(false);
            if (timers > 0)
            {
                _enemyHelicopterDestroy.SetActive(true);
                _enemyHelicopterDestroy.transform.Rotate(0, 0, 1f);
                if (gameObject.CompareTag("HelicopterL"))
                {
                    _enemyHelicopterDestroy.transform.Translate(-0.05f * Time.deltaTime, 0.1f * Time.deltaTime, 0);
                }
                else
                {
                    _enemyHelicopterDestroy.transform.Translate(0.05f * Time.deltaTime, 0.1f * Time.deltaTime, 0);
                }
            }
            else
            {
                _enemyHelicopterDestroy.SetActive(false);
                Destroy(_enemyHelicopter);
            }
        }
    }

}
