using UnityEngine;

public class EnemyTank : MonoBehaviour, I_EnemyStatick
{

    private int health = 5;
    private float timers = 3f;
    [SerializeField] GameObject _enemyTank;
    [SerializeField] GameObject _tank;
    [SerializeField] GameObject _enemyTankDestroy;
    [SerializeField] Animator _animator;
    [SerializeField] private AudioSource _shotTank;



    public void OnTouchAttack()
    {
        health--;
        _animator.Play("Explosion");
        _shotTank.Play();
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
        if (transform.position.y <= -0.3f)
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
            _tank.SetActive(false);
            if (timers > 0)
            {
                _enemyTankDestroy.SetActive(true);
                _enemyTankDestroy.transform.Translate(0, 0.1f * Time.deltaTime, 0);
            }
            else
            {
                _enemyTankDestroy.SetActive(false);
                Destroy(_enemyTank);
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
