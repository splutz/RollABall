using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MovementController : NetworkBehaviour {

	// Use this for initialization
	void OnStartLocalPlayer() {
		GetComponent<Material>().color = Color.blue;
	}

	void Update() {

		if (!isLocalPlayer) {
			return;
		}

		var rb = GetComponent<Rigidbody> ();

		var x = Input.GetAxis ("Horizontal") * Time.deltaTime * 5.0f;
		var z = Input.GetAxis ("Vertical") * Time.deltaTime * 5.0f;

		rb.AddForce (new Vector3 (x, 0.0f, z) * 50.0f);

		if (Input.GetKeyDown ("space")) {
			rb.AddForce (Vector3.up * 200.0f);
		}
	}
}
