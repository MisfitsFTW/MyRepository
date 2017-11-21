using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadNewScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void BrickDestroy()
    {
        if (BrickScript.breakableCount <= 0)
        {
            LoadNextScene();
        }
    }
    public void LoadNextScene()
    {
        BrickScript.breakableCount = 0;
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        //buildScene is the number of the level
        SceneManager.LoadScene(currentScene + 1);
    }
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
