using UnityEngine;
using System.Collections;

public class PlatformMovement : MonoBehaviour {

	public float platformSpeed = 5f;
	public bool moveRight = true;

	private Rigidbody rb;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{	
		if (moveRight) 
		{
			rb.velocity = new Vector3 (platformSpeed, 0f, 0f);
			if (transform.position.x >= 7.3)
				moveRight = false;
		}
		else if (!moveRight) 
		{
			rb.velocity = new Vector3 (-platformSpeed, 0f, 0f);
			if (transform.position.x <= -7.3)
				moveRight = true;
		}
		//if (transform.position.x >= 7.3 || transform.position.x <= -7.3) 
			//startRight = !startRight;

	}
}
