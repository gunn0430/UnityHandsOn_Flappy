using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {
	public Vector2 jumpPower = new Vector2(0,5.0f);
	private Rigidbody2D rigidbody2D;
	GameManager gameManager;

	void Start () {
		rigidbody2D = gameObject.GetComponent<Rigidbody2D> ();
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
		rigidbody2D.velocity = jumpPower;
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			rigidbody2D.velocity = jumpPower;
		}
		if (Input.touchCount > 0) {
			Touch touch = Input.GetTouch (0);
			if (touch.phase == TouchPhase.Began) {
				rigidbody2D.velocity = jumpPower;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		gameManager.Result ();
		Destroy (this.gameObject);
	}

	void OnTriggerExit2D(Collider2D col){
		//score update
		if(col.tag == "wall"){
			gameManager.score++;
			gameManager.ScoreUpdate();
		}
	}
}
