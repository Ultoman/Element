using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 10f;
	public float jumpForce = 100f;
	public float airForce = 100f;

	private float vertical;
	private float horizontal;
	private float jump;
	private Rigidbody rb;
	private SphereCollider sc;
	private RaycastHit hit;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
		sc = GetComponent<SphereCollider> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		vertical = Input.GetAxis ("Vertical");
		horizontal = Input.GetAxis ("Horizontal");
		//If the object is on ground
		if (isGrounded())
		{	// and jump is pressed you will jump
			if (Input.GetButton("Jump"))
				rb.AddForce (new Vector3 (0.0f, jumpForce, 0.0f));
				//rb.velocity = (new Vector3 (0.0f, jumpForce, 0.0f));
			else
				//rb.AddForce (new Vector3 (horizontal, 0.0f, vertical) * speed);
				rb.velocity = ((new Vector3 (horizontal, 0.0f, vertical) * speed) + addVelocity());
		}
		// If the object is in the air, apply air resistence
		else
		{
			rb.AddForce (new Vector3 (horizontal, 0.0f, vertical) * airForce);
			//rb.velocity = (new Vector3 (horizontal, 0.0f, vertical) * (speed / 5));
		}
			
	}

	private bool isGrounded()
	{
		return Physics.Raycast (transform.position, Vector3.down, (sc.radius + float.Epsilon), 3, QueryTriggerInteraction.Ignore);
	}

	private Vector3 addVelocity()
	{
		if (!isGrounded ())
			return Vector3.zero;

		Physics.Raycast (transform.position, Vector3.down, out hit, (sc.radius + float.Epsilon), 3, QueryTriggerInteraction.Ignore);
		if (hit.rigidbody == null)
			return Vector3.zero;
		else
			return hit.rigidbody.velocity;
	}
}
