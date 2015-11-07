using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject player;
	public float odmakKamere;

	public float odmakPozadine;

	void Update()
	{
		transform.position = new Vector3 (player.transform.position.x+odmakKamere,transform.position.y,transform.position.z);

	}

	void OnTriggerExit2D(Collider2D kolajder)
	{
		if (kolajder.CompareTag("bg"))
			kolajder.transform.position = new Vector2 (kolajder.transform.position.x+odmakPozadine,kolajder.transform.position.y);

	}


}

