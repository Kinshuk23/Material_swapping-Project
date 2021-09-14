using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class T_MoveScript : MonoBehaviour 
{
	public Transform m_Destination;

	NavMeshAgent m_NavMeshAgent;

	Vector3 targetPosition;

	void Start () 
	{
		m_NavMeshAgent = GetComponent<NavMeshAgent> ();

		if (m_NavMeshAgent == null) 
		{
			Debug.Log ("No NavMesh Compnenet Attached with the Object");
		}
		else 
		{
			m_SetDestination ();
		}
	}

	private void m_SetDestination()
	{
		targetPosition = m_Destination.transform.position;
		m_NavMeshAgent.SetDestination (targetPosition);
	}

}
