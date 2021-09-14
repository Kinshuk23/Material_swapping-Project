using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink_Script : MonoBehaviour {


	MeshRenderer m_renderer;
	Color c;

	void Start () 
	{
		m_renderer = GetComponent<MeshRenderer> ();
		c = m_renderer.material.color;
		StartCoroutine (FadeOut());
	}


	void Update()
	{
		if (m_renderer.material.color.a == 0.0f) 
		{
			StartCoroutine ("FadeIn");
		} 
		else if(m_renderer.material.color.a == 1.0f)
		{
			StartCoroutine ("FadeOut");
		}
	}

	IEnumerator FadeOut() 
	{
		for (float f = 1f; f >= 0; f -= 0.25f) 
		{
			c.a = f;
			m_renderer.material.color = c;
			yield return new WaitForSeconds (0.1f);
		}
	}

	IEnumerator FadeIn()
	{
		for (float v = 0f; v <= 1f; v += 0.25f) 
		{
			c.a = v;
			m_renderer.material.color = c;
			yield return new WaitForSeconds (0.1f); 
		}

	}
}
