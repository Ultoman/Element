using UnityEngine;
using System.Collections;

public class ElementScript : MonoBehaviour {

	public Material[] element;

	private MeshRenderer render;

	// Use this for initialization
	void Start () 
	{
		render = GetComponent<MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		

		if (Input.GetButtonDown ("One")) {
			render.material = element [1];
			gameObject.tag = "Fire";
		} else if (Input.GetButtonDown ("Two")) {
			render.material = element [2];
			gameObject.tag = "Water";
		} else if (Input.GetButtonDown ("Three")) {
			render.material = element [3];
			gameObject.tag = "Earth";
		} else if (Input.GetButtonDown ("Four")) {
			render.material = element [4];
			gameObject.tag = "Air";
		}
	}


}
