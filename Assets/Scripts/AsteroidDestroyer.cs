using UnityEngine;
using System.Collections;

public class AsteroidDestroyer : MonoBehaviour {

	private TextMesh scoreText;
	private int score = 0;
	void Start () 
	{
		scoreText = GameObject.Find("GameManager").GetComponent<TextMesh>();
	}
	
	
	void OnTriggerEnter2D (Collider2D col) 
	{
		Destroy(col.gameObject);
		score++;
		scoreText.text = "Score: " + score;
	}
}
