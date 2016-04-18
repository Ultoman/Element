using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FailureScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.name == "Player")
		Invoke ("LevelRestart", 2);
	}

	private void LevelRestart()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
