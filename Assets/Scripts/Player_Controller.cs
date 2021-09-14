using UnityEngine;
using UnityEngine.AI;

public class Player_Controller : MonoBehaviour 
{
	public NavMeshAgent agent;
	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) 
			{
				agent.SetDestination (hit.point);
			}
		}
	}
}
