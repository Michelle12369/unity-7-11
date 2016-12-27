using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PeopleController : MonoBehaviour {

	private Animator animatorController;
	public GameObject item;//get item
	public GameObject dollar;//get dollar
	private Renderer rend;//get item mesh renderer
	private TextMesh text;

	public Text input_num;
	private bool still = false;
	private bool correct = false;
	private GameObject[] numberobj;
//	public InputField user_Input;

	// Use this for initialization
	void Start () {
		animatorController = this.GetComponent<Animator> ();
		rend = item.GetComponent<Renderer>();
		Color newColor =  new Color( Random.value, Random.value, Random.value, 1.0f );
		rend.material.color = newColor;
		text=dollar.GetComponent<TextMesh> ();
		text.text = "$"+Random.Range(1, 200).ToString();


		numberobj = GameObject.FindGameObjectsWithTag("Number");


	}

	// Update is called once per frame
	void Update () {
		Text numberText = numberobj[0].GetComponent<Text> ();
		print (numberText.text);
		if( ("$"+numberText.text ) == text.text ){
			correct = true;
		}
//		print (input_num.text);
//		if( ("$"+input_num.text ) == text.text ){
//			correct = true;
//		}


		if(this.transform.position.x < -0.5f  && still == false ){
			animatorController.SetBool ("walking", true);
			this.transform.Translate(Vector3.forward * Time.deltaTime);
		}else if (this.transform.position.x > -0.5f || still ==true ){
			animatorController.SetBool ("walking", false);
			transform.rotation = Quaternion.AngleAxis(145, Vector3.up);

			if( correct == true ){
				animatorController.SetBool ("walking", true);
				transform.rotation = Quaternion.AngleAxis( 80 , Vector3.up);
				this.transform.Translate(Vector3.forward * Time.deltaTime);
			}
		}
	}
	void OnTriggerEnter(Collider coll) {//撞到
//		Debug.Log ("撞到:" + coll.gameObject.transform.position.x);
		if (coll.gameObject.transform.position.x < 0) {
			still = true;
		}
		if (coll.gameObject.transform.position.x > 0) {
			still = false;
		}

//		Destroy (coll.gameObject);
//		this.transform.position.x = 
//		this.transform.Translate(Vector3.forward*0); 
//		this.transform.position.x= coll.gameObject.transform.position.x;
	}

}
