using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navmeshcode : MonoBehaviour {

    public GameObject player;
    NavMeshAgent nav;
	// Use this for initialization
	void Start () {
        //player = GameObject.Find("Nino");
        nav = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        nav.SetDestination (player.transform.position);
	}
}
