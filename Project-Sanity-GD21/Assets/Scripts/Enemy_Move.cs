using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Move : MonoBehaviour
{
    private NavMeshAgent Enemy;

    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Enemy = GetComponent<NavMeshAgent>();
        Player=GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Enemy.SetDestination(Player.transform.position);
    }
    
}
