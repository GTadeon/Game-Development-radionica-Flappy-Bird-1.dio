using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandomString : MonoBehaviour {

	public string[] Zanrovi;
	private Text tekst;
	private bool pozovi=true;
	public float cekaj;

	void Start()
	{
		tekst = this.GetComponent<Text> ();
	}

	void Update()
	{
		if (pozovi)
			StartCoroutine (Ispisi ());
	}

	IEnumerator Ispisi()
	{
		pozovi=false;
		while (true) 
		{
			tekst.text=Zanrovi[(int)Random.Range(0,6f)];
			if (Input.GetKey(KeyCode.Space))
			{
				tekst.text=Zanrovi[(int)Random.Range(0,6f)];
				yield break;
			
			}
			else
			{
				tekst.text=Zanrovi[(int)Random.Range(0,6f)];
				yield return new WaitForSeconds(cekaj);
			}
		}

	}



}
