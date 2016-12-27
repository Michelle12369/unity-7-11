using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Number_Input : MonoBehaviour {

// Use this for initialization
	private Button[] num;
	private Text[] text;

	private string Input_num = "0";
	void Start () {
		num = this.GetComponentsInChildren<Button>();
		text = this.GetComponentsInChildren<Text>();

		num[0].onClick.AddListener(()=>TaskOnClick(0) );
		num[1].onClick.AddListener(()=>TaskOnClick(1) );
		num[2].onClick.AddListener(()=>TaskOnClick(2) );
		num[3].onClick.AddListener(()=>TaskOnClick(3) );
		num[4].onClick.AddListener(()=>TaskOnClick(4) );
		num[5].onClick.AddListener(()=>TaskOnClick(5) );
		num[6].onClick.AddListener(()=>TaskOnClick(6) );
		num[7].onClick.AddListener(()=>TaskOnClick(7) );
		num[8].onClick.AddListener(()=>TaskOnClick(8) );
		num[9].onClick.AddListener(()=>TaskOnClick(9) );

		num[10].onClick.AddListener(()=>TaskOnClick(10) );
		num[11].onClick.AddListener(()=>TaskOnClick(11) );

	}
	void TaskOnClick( int idx){
		string new_num = "0";
		if (idx < 10) {
			new_num = num [idx].GetComponentInChildren<Text> ().text;
		} else if (idx == 10) {
			new_num = "0";
			text [12].text = "0";
		} else if (idx == 11) {//按Go的時候的反應
			text [13].text = text[12].text;
			//歸零
			new_num = "0";
			text [12].text = "0";
		}

		if (text [12].text == "0") {
			Input_num = new_num;
			text [12].text = Input_num;
		} else {
			Input_num = Input_num + new_num;
			text [12].text = Input_num;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
