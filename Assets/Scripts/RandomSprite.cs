using UnityEngine;
using System.Collections;

public class RandomSprite : MonoBehaviour {

	public Sprite[] sprites;
	
	void Start () 
	{
		int randomSprite = Random.Range(0,sprites.Length);
		transform.GetComponent<SpriteRenderer>().sprite = sprites[randomSprite];
	}
}
