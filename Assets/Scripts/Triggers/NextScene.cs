using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter()
	{
		Invoke ("SceneLoad", 1);
	}

	private void SceneLoad()
	{
		SceneManager.LoadScene ("Level1");
	}

}
