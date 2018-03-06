using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMovement : MonoBehaviour {
	public KeyCode upKey;
	public KeyCode downKey;
	public KeyCode leftKey;
	public KeyCode rightKey;
	private Rigidbody2D rb;
	public float rateOfHorizontalSpeed;
	public float rateOfVerticalSpeed;
	public float horizontalForce;
	public float verticalForce;
	// private Vector2 force;


	void Start () {
		rb = GetComponent<Rigidbody2D>();


		
	}//END START
	

	void FixedUpdate () {


	
			if (Input.GetKey (upKey))
				moveUp ();
			
			//if (Input.GetKeyDown (downKey))
			if (Input.GetKey(downKey))
				moveDown ();
			
			//if (Input.GetKeyDown (leftKey))
			if (Input.GetKey(leftKey))
				moveLeft ();
			
			
			//if (Input.GetKeyDown (rightKey))
			if (Input.GetKey (rightKey))
				moveRight ();

		//else rb.velocity = new Vector2(0,0);
		}//END FIXED UPDATE

	void moveUp() {
		//rb.velocity = new Vector2 (rb.velocity.x, rateOfVerticalSpeed);
	//	force = new Vector2 (0, verticalForce);
		rb.AddForce (Vector2.up * verticalForce);
		}//END MOVE UP

	void moveDown(){
		//rb.velocity = new Vector2 (rb.velocity.x, ((rateOfVerticalSpeed)*-1));
		//force = new Vector2 (0, verticalForce);
		rb.AddForce (Vector2.down * verticalForce);

		}//END MOVE DOWN

	void moveLeft (){
		//rb.velocity = new Vector2 (((rateOfHorizontalSpeed)*-1), rb.velocity.y);
		//force = new Vector2 (horizontalForce, 0);
		rb.AddForce (Vector2.left * horizontalForce);
	
		}//END MOVE LEFT

	void moveRight(){
		//rb.velocity = new Vector2 (rateOfHorizontalSpeed, rb.velocity.y);
		//force = new Vector2 (horizontalForce, 0);
		rb.AddForce (Vector2.right * horizontalForce);	
		}//END MOVE RIGHT

}//END BAR MOVEMENT SCRIPT