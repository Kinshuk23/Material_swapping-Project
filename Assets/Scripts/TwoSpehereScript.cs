using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoSpehereScript : MonoBehaviour 
{

	MeshRenderer m_Renderer;
	Color m_Color;
	public bool _isVisible;

	void Start()
	{
		m_Renderer = GetComponent<MeshRenderer> ();
		m_Color = m_Renderer.material.color;
//		FadeOutStarter ();
	}


	public void FadeInStarter()
	{
		StartCoroutine ("FadeIn");
	}

	public void FadeOutStarter()
	{
		StartCoroutine ("FadeOut");
	}

	IEnumerator FadeIn()
	{
		for (float v = 0f; v <= 1f; v += 0.25f) 
		{
			m_Color.a = v;
			m_Renderer.material.color = m_Color;
			yield return new WaitForSeconds (0.1f); 
		}
		_isVisible = true;
	}

	IEnumerator FadeOut()
	{
		for (float f = 1f; f >= 0f; f -= 0.25f) 
		{
			m_Color.a = f;
			m_Renderer.material.color = m_Color;
			yield return new WaitForSeconds (0.1f);
		}
		_isVisible = false;
	}
}
