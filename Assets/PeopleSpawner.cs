using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class PeopleSpawner : MonoBehaviour {

	public GameObject PeopleCandidate;
	public List<Transform> SpawnPoint;
	public float SpawnTime = 10;
	private float SpawnCounter = 0;
	private int count = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		SpawnCounter += Time.deltaTime;
		if (SpawnCounter >= SpawnTime && count < 6 ) {
			SpawnCounter = 0;
			GameObject newPeople = GameObject.Instantiate (PeopleCandidate);

//			GameObject numberobj = GameObject.FindGameObjectsWithTag("Number");
//			Text numberText = numberobj.GetComponent<Text> ();


//			newPeople.transform.SetParent(this.transform);
//			Text text = newPeople.AddComponent<Text>();
//			text.text = "Ta-dah!";

			count++;
		}
	}
}
