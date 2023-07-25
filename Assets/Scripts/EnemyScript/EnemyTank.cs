using UnityEngine;

public class EnemyTank : MonoBehaviour
{

    private int health = 5;
    private float timers = 3f;
    [SerializeField] GameObject _enemyTank;
    [SerializeField] GameObject _tank;
    [SerializeField] GameObject _enemyTankDestroy;
    [SerializeField] Animator _animator;

   
    public void OnTouchAttack()
    {
        health--;
        _animator.Play("Explosion");
    }
    
    private void Update()
    {
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
            }
        }
    }

}
