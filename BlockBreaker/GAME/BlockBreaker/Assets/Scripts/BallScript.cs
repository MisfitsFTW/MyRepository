using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	PaddleScript paddle;
	Vector3 paddleBallPosDiff;//Vector 3 is a position
	bool gameStart=false;

	// Use this for initialization
	void Start () {
        paddle=GameObject.FindObjectOfType<PaddleScript> ();
		paddleBallPosDiff = this.transform.position - paddle.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		if (!gameStart) {//if(gameStart==false)
			this.transform.position = paddle.transform.position + paddleBallPosDiff;
		}
		if (Input.GetMouseButtonDown (0) && !gameStart) {
			gameStart = true;
			this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
			//using x or y, due to physics. 2f=speed on x. 10f=speed on y
		}
			
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
    }
}
