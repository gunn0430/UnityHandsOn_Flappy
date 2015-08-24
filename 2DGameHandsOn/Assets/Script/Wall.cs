using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {
	public Vector3 moveVec = new Vector3(-0.1f,0,0);
	
	void FixedUpdate () {
		gameObject.transform.Translate (moveVec);
	}
}
