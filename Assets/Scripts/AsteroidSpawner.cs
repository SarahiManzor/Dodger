using UnityEngine;
using System.Collections;

public class AsteroidSpawner : MonoBehaviour
{
	public GameObject asteroid;
	private float frequency = 1.0f;
	private int counter = 0;
	private int totalCounter;
	private Camera cam;
	private GameObject parent;
	
	void Start()
	{
		Application.targetFrameRate = 60;
		cam = Camera.main;
		parent = this.gameObject;
	}
	
	void FixedUpdate () 
	{
		//Debug.Log (frequency);
		counter++;
		totalCounter++;
		if(totalCounter % 750 == 0)
		{
			frequency *= 3f/4f;
		}
		if(counter >= frequency*50f)
		{
			Spawn();
			counter = 0;
		}
	}
	
	void Spawn()
	{
		GameObject newObject = (GameObject) GameObject.Instantiate(asteroid);
		float objWidth = asteroid.GetComponent<CircleCollider2D>().radius;
		float minX = cam.transform.position.x - (cam.orthographicSize*Screen.width/Screen.height) + objWidth;
		float maxX = cam.transform.position.x + (cam.orthographicSize*Screen.width/Screen.height) - objWidth;
		float range = maxX - minX;
		float randomX = minX + Random.Range(0, range*range)%range;
		newObject.transform.position = new Vector2(randomX,cam.transform.position.y + cam.orthographicSize + 1f);
		newObject.transform.parent = parent.transform;
	}
}
