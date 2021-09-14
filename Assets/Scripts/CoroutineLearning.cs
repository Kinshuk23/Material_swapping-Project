using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObjectScript : MonoBehaviour 
{
	
	void Start () 
	{
		Debug.Log ("Started");
		StartCoroutine (One());
		Debug.Log ("Meri baari aa gai");
	}

	IEnumerator One()
	{
		Debug.Log ("I am In and think have to wait");
		yield return new WaitForSeconds (7);
		Debug.Log ("Going into Two()");
		StartCoroutine (Two());
		Debug.Log ("wait Over");
	}

	IEnumerator Two()
	{
		Debug.Log ("Into Two and will wait");
		yield return new WaitForSeconds (3);
		Debug.Log ("Wait over for Two()");
	}
}
