using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float FlapSpeed = 200.0f;
	// Verticalinput must be float because GetAxisRaw returns float
	public float VerticalInput;

	private Rigidbody2D RB2D;


	// Use this for initialization
	void Start () {
		// Get the RigidBody component
		// Before Unity 5 we use to use rigidboy2D instance 
		//but in Unity 5 they removed it so we have to get the component first
		RB2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		// GetAxisRaw returns a direction either -1, 0, or 1 
		VerticalInput = Input.GetAxisRaw("Vertical") * FlapSpeed;

	}

	void FixedUpdate(){

		if(VerticalInput > 0)
		{
			// Activate Gravity 
			// Move up with each press. Can't hold and press to fly to infinity and beyond of the screen. 
			// Double Jump 
			// Clamp the jump
			RB2D.gravityScale = 1;
			RB2D.AddRelativeForce(new Vector2(0.0f, VerticalInput));
		}

	}
}
