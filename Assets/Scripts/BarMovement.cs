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



	void Start () {
		rb = GetComponent<Rigidbody2D>();
			
		
	}//END START
	

	void FixedUpdate () {
		
		if (Input.anyKeyDown) {
			if (Input.GetKeyDown (upKey))
				moveUp ();
			
			
			if (Input.GetKeyDown (downKey))
				moveDown ();
			

			if (Input.GetKeyDown (leftKey))
				moveLeft ();
			
			
			if (Input.GetKeyDown (rightKey))
				moveRight ();
	
		} 
		else rb.velocity = new Vector2(0,0);


		}//END FIXED UPDATE

	void moveUp() {
		rb.velocity = new Vector2 (rb.velocity.x, rateOfVerticalSpeed);

		}//END MOVE UP

	void moveDown(){
		rb.velocity = new Vector2 (rb.velocity.x, ((rateOfVerticalSpeed)*-1));


		}//END MOVE DOWN

	void moveLeft (){
		rb.velocity = new Vector2 (((rateOfHorizontalSpeed)*-1), rb.velocity.y);
	

		}//END MOVE LEFT

	void moveRight(){
		rb.velocity = new Vector2 (rateOfHorizontalSpeed, rb.velocity.y);

		}//END MOVE RIGHT

}//END BAR MOVEMENT SCRIPT