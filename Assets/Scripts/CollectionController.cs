using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CollectionController : NetworkBehaviour {



	// Use this for initialization
	void OnCollisionEnter(Collision col) {

		if (!isLocalPlayer)
			return;

		Debug.Log ("Collision occurred:" + col.gameObject.tag);

		if (col.gameObject.tag == "Collectible") {

			if (isServer) {
//				Destroy (col.gameObject);
				NetworkServer.Destroy (col.gameObject);
				// score the point
				Scoring manager = GameObject.FindWithTag("ScoreManager").GetComponent<Scoring>();
				Debug.Log ("invoked score()");
				manager.score ();
			}
		}
	}
}
