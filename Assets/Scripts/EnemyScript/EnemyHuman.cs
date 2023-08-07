using UnityEngine;

public class EnemyHuman : MonoBehaviour, I_EnemyStatick
{

    private int health = 2;
    private float timers = 3f;
    [SerializeField] GameObject _enemyHuman;
    [SerializeField] GameObject _human;
    [SerializeField] GameObject _enemyHumanDestroy;
    [SerializeField] Animator _animator;
    [SerializeField] GameObject _rocket;
    [SerializeField] private AudioSource _shotPeople;
    [SerializeField] private AudioSource _shop;


    public void OnTouchAttack()
    {
        health--;
        _animator.Play("Explosion");
        _shop.Play();
    }
    
    private void FixedUpdate()
    {
        DestroyEnemy();
        EmenyActive();
        EmenyAttack();
    }

    

    public void DestroyEnemy()
    {
        if (_enemyHuman.transform.position.y >= 1.2f)
        {
            Destroy(_enemyHuman);
        }
    }

    public void EmenyActive()
    {
        if (transform.position.x <= -0.25f)
        {
            transform.Translate(0.0050f, 0, 0);
        }
        else
        {
            transform.Translate(0, 0.0025f, 0);
        }

        if (health <= 0)
        {
            timers -= Time.deltaTime;
            _human.SetActive(false);
            if (timers > 0)
            {
                _enemyHumanDestroy.SetActive(true);
                _enemyHumanDestroy.transform.Translate(0, 0, 0);
            }
            else
            {
                _enemyHumanDestroy.SetActive(false);
                Destroy(_enemyHuman);
            }
        }
    }

    public void EmenyAttack()
    {
        if (!GameObject.FindGameObjectWithTag("Rocket") && health > 0)
        {
            Invoke("SpawnRocket", 3);
        }
        else
        {
            CancelInvoke("SpawnRocket");
        }
    }

    public void SpawnRocket()
    {
        Instantiate(_rocket,gameObject.transform);
        _shotPeople.Play();
    }
}
