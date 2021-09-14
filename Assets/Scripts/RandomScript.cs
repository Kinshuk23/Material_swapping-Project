using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomScript : MonoBehaviour {

	Vector3 randomPosition;

	void Start()
	{
		randomPosition = new Vector3 (Random.Range(-5.0f,5.0f), 0, Random.Range(-5.0f, 5.0f));
		gameObject.transform.position = randomPosition;
	}

	/*void Update () 
	{
		randomPosition = new Vector3 (Random.Range(-5.0f, 5.0f), 0, Random.Range(-5.0f, 5.0f));
		gameObject.transform.position = randomPosition;
	}*/
}
