using UnityEngine;

public class EnemyHelicopter : MonoBehaviour, I_EnemyStatick
{

    private int health = 8;
    private float timers = 3f;
    [SerializeField] GameObject _enemyHelicopter;
    [SerializeField] GameObject _bodyHelicopter;
    [SerializeField] GameObject _enemyHelicopterDestroy;
    [SerializeField] Animator _animator;
    [SerializeField] private AudioSource _shotHelicopter;



    public void OnTouchAttack()
    {
        health--;
        _animator.Play("Explosion");
        _shotHelicopter.Play();
    }

    private void Update()
    {
        EmenyActive();
    }

    public void DestroyEnemy()
    {
        throw new System.NotImplementedException();
    }

    public void EmenyActive()
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


    public void EmenyAttack()
    {
        throw new System.NotImplementedException();
    }

    public void SpawnRocket()
    {
        throw new System.NotImplementedException();
    }
}
