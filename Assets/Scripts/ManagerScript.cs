using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour {

	public TwoSpehereScript sc1, sc2;

	void Start()
	{
		if (sc2._isVisible == true) {
			Debug.Log ("Blue Alpha zero");
			sc2.FadeOutStarter ();
		}
	}

	void Update () 
	{
		if (Input.GetKey (KeyCode.Space)) 
		{
			if (sc1._isVisible == true && sc2._isVisible == false) {
				Debug.Log ("Second_Condition");
				sc1.FadeOutStarter ();
				sc2.FadeInStarter ();
			} else {
				Debug.Log ("Third_Condition");
				sc1.FadeInStarter ();
				sc2.FadeOutStarter ();
			}
		}
	}
}
