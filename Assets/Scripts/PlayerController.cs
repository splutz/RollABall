using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {

	// Use this for initialization
	void OnStartLocalPlayer() {
		GetComponent<Material>().color = Color.blue;
	}

	void Update() {

		if (!isLocalPlayer) {
			return;
		}

		var x = Input.GetAxis ("Horizontal") * Time.deltaTime * 5.0f;
		var z = Input.GetAxis ("Vertical") * Time.deltaTime * 5.0f;

		transform.Translate (new Vector3(x, 0.0f, z));

	}
}
