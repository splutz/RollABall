using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Scoring : NetworkBehaviour {

	public GameObject label;

	[SyncVar]
	public int scorenum = 0;

	public void score() {
		
		if (isServer) {
			scorenum++;
			var txt = scorenum + " cubes collected";
			Debug.Log (txt);

			label.GetComponent<TextMesh> ().text = txt;
		}
	}
}
