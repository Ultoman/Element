using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ExitTrigger : MonoBehaviour {

	public GameObject win;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Player")
			win.SetActive (true);
	}
}
