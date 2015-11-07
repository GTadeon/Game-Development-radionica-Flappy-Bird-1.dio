using UnityEngine;
using System.Collections;

public class PomakniCijevi : MonoBehaviour {

	public float odmakCijevi;

	void OnTriggerExit2D(Collider2D kolajder)
	{
		if (kolajder.CompareTag("pipe"))
			kolajder.transform.position = new Vector2 (kolajder.transform.position.x+odmakCijevi,kolajder.transform.position.y);
		
	}
}
