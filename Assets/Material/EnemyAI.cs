using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyAI : MonoBehaviour {
	
	NavMeshAgent nav;
	GameObject target;
	
	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent>();
		target = GameObject.Find("Player");
		Debug.Log (target);
		//Debug.Log (nav.destination);

	}
	
	// Update is called once per frame
	void Update () {

		if (nav.destination != target.transform.position)
		{
			//Debug.Log(target.transform.position);
			nav.SetDestination (target.transform.position);
		}
		else
		{
			nav.SetDestination (transform.position);
		}
	}
}
