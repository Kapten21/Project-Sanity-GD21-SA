using UnityEngine;
using System.Collections;


public class EnemyAttack : MonoBehaviour
{
    private Animator _animator;
    private GameObject Player;
    private bool _collidedWithPlayer;

    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        _animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            _animator.SetBool("IsNearPlayer", true);
        }
        print("enter trigger with _player");
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == Player)
        {
            _collidedWithPlayer = true;
        }
        print("enter collided with _player");
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject == Player)
        {
            _collidedWithPlayer = false;
        }
        print("exit collided with _player");
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            _animator.SetBool("IsNearPlayer", false);
        }
        print("exit trigger with _player");
    }

    private void Update()
    {
        if (_collidedWithPlayer)  
        {
            Player.GetComponent<PlayerHealth>().TakeDamage(10);
        }
        
    }
}