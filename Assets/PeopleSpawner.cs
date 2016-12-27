using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class PeopleSpawner : MonoBehaviour {

	public GameObject PeopleCandidate;
	public GameObject PeopleCandidate2;
	public GameObject PeopleCandidate3;
	public GameObject PeopleCandidate4;
	public List<GameObject> FourCandidate= new List<GameObject> ();
	public List<GameObject> AllPeople = new List<GameObject> ();
	public float SpawnTime = 10;
	private float SpawnCounter = 0;
	private int count = 0;
	private bool status;
	// Use this for initialization
	void Start () {
		FourCandidate.Add(PeopleCandidate);
		FourCandidate.Add(PeopleCandidate2);
		FourCandidate.Add(PeopleCandidate3);
		FourCandidate.Add(PeopleCandidate4);
	}
	
	// Update is called once per frame
	void Update () {
		SpawnCounter += Time.deltaTime;
		if (SpawnCounter >= SpawnTime && count < 5 ) {
			SpawnCounter = 0;
			GameObject newPeople = GameObject.Instantiate (FourCandidate[Random.Range(0, FourCandidate.Count)]);
			AllPeople.Add (newPeople);
			count++;
		}
	}

	public void getCorrect(bool correct){
		status = true;
		print ("true");
		for (int i = 1; i < AllPeople.Count; i++) {
			GameObject people=AllPeople[i];
			PeopleController peopleScript=(PeopleController)people.GetComponent(typeof(PeopleController));
			peopleScript.go ();
		}
	}
		
}
