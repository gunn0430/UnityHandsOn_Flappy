using UnityEngine;
using System.Collections;

public class DestroyArea : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		if(col.tag == "wall"){
			Destroy (col.gameObject);
		}
	}
}
