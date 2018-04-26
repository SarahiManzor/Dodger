using UnityEngine;
using System.Collections;

public class AsteroidBehaviour : MonoBehaviour 
{
	void Start () 
	{
		transform.GetComponent<Rigidbody2D>().velocity = new Vector2(0f,-3.5f);
		float randomSpeed = Random.Range(-100f,100f);
		transform.GetComponent<Rigidbody2D>().angularVelocity = randomSpeed;;
	}

    void OnTriggerEnter2D(Collider2D col){
        if (col.tag == "Bullet"){
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }
}
