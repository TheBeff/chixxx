using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarCollision : MonoBehaviour {										// BarCollision Script
																				// to test the nipple cover feature


	private BoxCollider2D barCollider;											// var to rename for our box collider 2d (the censor bar)
	public CircleCollider2D nippleCollider;										// var for our circle collider 2d (the nipple to be covered)


	void Start () {																// Start Function
		barCollider = GetComponent<BoxCollider2D> ();							// assign the var 'barCollider' to the box collider component of this game object
	} // END START

	void Update () {															// Update Function
		if (barCollider.bounds.Contains (nippleCollider.bounds.min) &&			// if the bounds of the barCollider contain the minimum bounds of the nippleCollider AND
		    barCollider.bounds.Contains (nippleCollider.bounds.max)) {			// the bounds of the barCollider contain the maximum bounds of the nippleCollider, THEN
			Debug.Log ("you covered the nipple");								// print the phrase "you covered the nipple" to the console
		} // end collider bounds
	
	} // END UPDATE

} // END SCRIPT
