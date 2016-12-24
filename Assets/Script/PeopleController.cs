using UnityEngine;
using System.Collections;

public class PeopleController : MonoBehaviour {

	private Animator animatorController;
	public GameObject item;//get item
	public GameObject dollar;//get dollar
	private Renderer rend;//get item mesh renderer
	private TextMesh text;
	// Use this for initialization
	void Start () {
		animatorController = this.GetComponent<Animator> ();
		rend = item.GetComponent<Renderer>();
		Color newColor =  new Color( Random.value, Random.value, Random.value, 1.0f );
		rend.material.color = newColor;
		text=dollar.GetComponent<TextMesh> ();
		text.text = "$"+Random.Range(0, 200).ToString();
	}

	// Update is called once per frame
	void Update () {
		if(this.transform.position.x < -0.5f){
		animatorController.SetBool ("walking", true);
		this.transform.Translate(Vector3.forward * Time.deltaTime);
		}else if (this.transform.position.x > -0.5f){
			animatorController.SetBool ("walking", false);
			transform.rotation = Quaternion.AngleAxis(145, Vector3.up);
		}

	}
	void OnTriggerEnter(Collider coll) {//撞到
		Debug.Log ("Collision" + coll.gameObject.transform.position.x);

		//this.transform.Translate(Vector3.forward*0); 
//				this.transform.position.x= coll.gameObject.transform.position.x;
	}
}
