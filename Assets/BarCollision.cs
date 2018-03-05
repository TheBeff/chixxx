using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarCollision : MonoBehaviour {

	private BoxCollider2D barCollider;
	public CircleCollider2D nippleCollider;

	// Use this for initialization
	void Start () {
		barCollider = GetComponent<BoxCollider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (barCollider.bounds.Contains (nippleCollider.bounds.min) &&
		    barCollider.bounds.Contains (nippleCollider.bounds.max)) {
			Debug.Log ("you covered the nipple");
		}
	}
}
