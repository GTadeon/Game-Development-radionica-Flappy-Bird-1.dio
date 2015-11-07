using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public ScoreUpdate scoreManager;
	public Vector2 brzina;
	private Rigidbody2D playerRB;
	private bool IsMoving;

	public Vector2 odraz;

	public GameObject smrt;
	

	void Start()
	{
		scoreManager = GameObject.Find ("Score").GetComponent<ScoreUpdate> ();
		playerRB=this.GetComponent<Rigidbody2D>();
		IsMoving = false;
	}


	void Update ()
	{
		if (IsMoving==false)
		{
			Pokreni();
		}

		if (Input.GetMouseButtonDown (0)) 
		{
			playerRB.AddForce(odraz);
		}
		if (playerRB.velocity.y > 0) 
		{
			//kljun gore
			float kut=Mathf.Lerp(0,90,playerRB.velocity.y/3f);
			transform.rotation=Quaternion.Euler(0,0,kut);

		} 
		else if (playerRB.velocity.y < 0) 
		{
			//kljun dolje
			float kut=Mathf.Lerp(0,-90,-playerRB.velocity.y/2f);
			transform.rotation=Quaternion.Euler(0,0,kut);
		}
	}

	void Pokreni()
	{
		playerRB.drag = 0;
		playerRB.AddForce (brzina);
		IsMoving = true;
	}

	void OnTriggerEnter2D(Collider2D kolajder)
	{
		Vector3 pozicija = this.transform.position;
		Quaternion rotacija = this.transform.rotation;

		if (kolajder.CompareTag ("pipe")) {
			Instantiate (smrt, pozicija, rotacija);
			gameObject.SetActive (false);
		} else if (kolajder.CompareTag ("DodajBod"))
			scoreManager.bod += 1;

	}
	
}
