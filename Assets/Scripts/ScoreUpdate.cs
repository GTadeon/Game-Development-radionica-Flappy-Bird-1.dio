using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour {

	private Text score;

	public int bod;

	void Start()
	{
		bod = 0;
		score = this.GetComponent<Text> ();
	}

	void Update ()
	{
		score.text = "Score: "+bod.ToString();
	}
}
