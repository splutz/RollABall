using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {

	// prefab to instantiate to spawn a collectible
	public GameObject collectible; 

	void Start() {
//		if (isServer) {
//			ClientScene.RegisterPrefab (collectible);
//		}
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
//			CmdSpawn ();

			Network.Instantiate (collectible, transform.position, transform.rotation);
		}
	}

	[Command]
	public void CmdSpawn() {

		GameObject obj = (GameObject)Instantiate (collectible, transform.position, transform.rotation);
		NetworkServer.Spawn (obj);
	}

}
