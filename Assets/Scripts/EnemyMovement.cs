using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    UnityEngine.AI.NavMeshAgent nav;
    Transform player;

    // Use this for initialization
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
    }

    // Update is called once per frame
    void Update ()
    {
        nav.SetDestination(player.position);
		
	}
}
