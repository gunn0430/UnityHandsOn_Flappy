using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {
	private float time = 0;
	private Vector3 spawnPoint;
	public float wallSpawnRate = 2.0f;
	public int score = 0;

	//gameObject
	public GameObject wall;
	public GameObject gameScoreObj;
	public GameObject resultCanvas;
	public GameObject resultScoreText;

	void Start(){
		Application.targetFrameRate = 60;
	}
	
	void Update () {
		time += Time.deltaTime;
		if(time > wallSpawnRate){
			time = 0f;
			spawnPoint = new Vector3(5.5f,Random.Range(-2.0f,3.0f),0);
			Instantiate(wall,spawnPoint,gameObject.transform.rotation);
		}
	}

	public void ScoreUpdate(){
		gameScoreObj.GetComponent<Text>().text = "SCORE\n"+score.ToString();
	}

	public void Result(){
		resultCanvas.GetComponent<Canvas> ().enabled = true;
		resultScoreText.GetComponent<Text> ().text = "SCORE\n\n"+score.ToString ();
	}

	public void Retry(){
		Application.LoadLevel (0);
	}
}
