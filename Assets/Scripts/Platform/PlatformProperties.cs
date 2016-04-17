using UnityEngine;
using System.Collections;

public class PlatformProperties : MonoBehaviour {

	private BoxCollider bc;

	// Use this for initialization
	void Start () 
	{
		bc = GetComponent<BoxCollider> ();
	}

	void OnCollisionStay(Collision other)
	{
		if (other.gameObject.name == "Player") 
		{
			if (other.gameObject.tag != gameObject.tag)
				bc.isTrigger = true;
		}
	}

	// Update is called once per frame
	void Update () 
	{
		
	}
}
