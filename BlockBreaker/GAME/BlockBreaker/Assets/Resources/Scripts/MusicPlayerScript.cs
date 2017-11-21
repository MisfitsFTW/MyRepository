using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerScript : MonoBehaviour {
	static MusicPlayerScript instance = null;
	// Use this for initialization
	private void Awake()//Awake is always executed first
	{
		print("player awake");
		if (instance != null)
		{
			print("Music player destroyed");
			Destroy(gameObject);
			//Therefore there will be no dublicate
			//music playing in the background
		}
		else//instance is null so it is the first
			//music player
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
