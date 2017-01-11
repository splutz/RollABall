using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {

	// prefab to instantiate to spawn a collectible
	public GameObject collectible; 

	// Update is called once per frame
	void Update () {

		if (!isLocalPlayer) {
			return;
		}

		if (Input.GetMouseButtonDown (0)) {

			CmdSpawn ();
		}
	}

	[Command]
	public void CmdSpawn() {

		if (isServer) {
			GameObject obj = (GameObject)Instantiate (collectible, new Vector3(0.0f, 4.0f, 0.0f), transform.rotation);
			NetworkServer.Spawn (obj);
		}
	}

}
