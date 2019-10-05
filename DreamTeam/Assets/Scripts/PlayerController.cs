using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed = 156.0f;
	private float speed1 = 156.0f;
	public Rigidbody rb;
		// Use this for initialization
	void Start () {
			rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		float moveHor = Input.GetAxis("Horizontal");
		float moveVer = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(moveHor, 0, moveVer);
		rb.AddForce(movement);
	}
}
