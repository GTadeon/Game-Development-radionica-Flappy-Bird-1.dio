using UnityEngine;
using System.Collections;

public class PustiZvukScorea : MonoBehaviour {

	private AudioSource zvukScorea;

	void Start()
	{
		zvukScorea = this.GetComponent<AudioSource> ();
	}

	void OnTriggerEnter2D(Collider2D kolajder)
	{
		if (kolajder.name == "Player") 
		{
			zvukScorea.Play();
		}
	}
}
