using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//print(Input.mousePosition.x);
		float mousePosInUnits = (Input.mousePosition.x / Screen.width * 16) - 8;

		Vector3 newPaddlePos = new Vector3(mousePosInUnits,gameObject.transform.position.y,gameObject.transform.position.x);//Transform is on the Inspector, it stores the positions


		newPaddlePos.x = Mathf.Clamp (mousePosInUnits, -7.35f, 7.35f);

		gameObject.transform.position = newPaddlePos;
		//this.transform.position=
	}
}
