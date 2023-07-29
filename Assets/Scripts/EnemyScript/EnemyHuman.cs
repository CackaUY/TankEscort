using UnityEngine;

public class EnemyHuman : MonoBehaviour
{

    private int health = 2;
    private float timers = 3f;
    [SerializeField] GameObject _enemyHuman;
    [SerializeField] GameObject _human;
    [SerializeField] GameObject _enemyHumanDestroy;
    [SerializeField] Animator _animator;
    

    public void OnTouchAttack()
    {
        health--;
        _animator.Play("Explosion");
    }
    
    private void Update()
    {
        DestroyHuman();
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

    void DestroyHuman()
    {
        if(_enemyHuman.transform.position.y >= 2)
        {
            Destroy(_enemyHuman);
        }
    }

}
