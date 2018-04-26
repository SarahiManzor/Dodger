using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour 
{
	public GameObject retryButton;
    public GameObject bullet;
    private int counter = 0;

	void Start () 
	{
		
	}

    void FixedUpdate(){
        counter++;
        if (counter >= 25){
            //GameObject newObject = (GameObject) GameObject.Instantiate(bullet);
            //newObject.transform.position = new Vector2(this.transform.position.x,this.transform.position.y + 1f);
            //newObject.transform.GetComponent<Rigidbody2D>().velocity = new Vector2(0f,4.5f);
            counter = 0;
        }
    }
	
	void OnTriggerEnter2D (Collider2D col) 
	{
		if (col.tag == "Enemy")
		{
			transform.GetComponent<SpriteRenderer>().color = new Color(0f,0f,0f);
			Time.timeScale = 0;
			GameObject retry = (GameObject)GameObject.Instantiate (retryButton);
			Vector3 camPos = Camera.main.transform.position;
			retry.transform.position = new Vector3(camPos.x,camPos.y,-1f);
		}
	}
}
