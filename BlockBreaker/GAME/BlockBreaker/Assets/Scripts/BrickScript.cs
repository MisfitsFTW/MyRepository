using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]//To ensure the brick has an audio source
public class BrickScript : MonoBehaviour {
    int timesHit;
    public int maxHits;
    public AudioClip crack;
	// Use this for initialization
	void Start () {

        timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        print(gameObject.name+" : "+timesHit);
        //gameObject.name is the name of the bricks(brick-brick(4))
        if (timesHit >= maxHits)
        {
            GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }
    }
}
