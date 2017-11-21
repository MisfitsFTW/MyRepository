using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]//To ensure the brick has an audio source
public class BrickScript : MonoBehaviour {

    public static int breakableCount = 0;

    int timesHit;
    public int maxHits;
    AudioClip crack;

    LevelManager levelManager = new LevelManager();
    //So we can load the next scene, like in lose border Script

	// Use this for initialization
	void Start () {
        breakableCount++;
        print(breakableCount);
        crack = Resources.Load("Sounds/crack", typeof(AudioClip)) as AudioClip;
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
            //TestWin();
            AudioSource.PlayClipAtPoint(crack, this.transform.position);
            breakableCount--;
            print(breakableCount);
            levelManager.BrickDestroy();
            Destroy(gameObject);
        }
    }
    void TestWin()
    {
        levelManager.LoadNextScene();
    }
}
