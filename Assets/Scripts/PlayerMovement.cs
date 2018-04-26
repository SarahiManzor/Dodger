using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{	
	private Transform player;
	private Camera cam;
    private int fingerID;
	void Start () 
	{
		cam = Camera.main;
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}

    void OnTouchDown(float[] posID)
    {
        //Debug.Log("DInputID:" + posID[2] + "><" + "fingerID:" + fingerID + "||" + posID[0]);
        if (fingerID == -1)
        {
            fingerID = (int) posID[2];
        }
    }
	
	void OnTouchStay(float[] posID)
    {
        //Debug.Log("SInputID:" + posID[2] + "><" + "fingerID:" + fingerID + "||" + posID[0]);
        if ((int)posID[3] == 1)
        {
            fingerID = (int) posID[2];
        }
        if ((int) posID[2] == fingerID)// || (int) posID[3] == 1)
        {
            if (Time.timeScale == 1f)
            {
                Vector3 newPos = cam.ScreenToWorldPoint(new Vector3(posID[0], posID[1], 0f));
                float newX = Mathf.Lerp(player.transform.position.x, newPos.x, 0.12f);
                float newY = Mathf.Lerp(player.transform.position.y, newPos.y, 0.12f);
                newX = Mathf.Clamp(newX, -2.0f, 2.0f);
                player.transform.position = new Vector2(newX, newY);
            }
        }
	}

    void OnTouchUp(float[] posID)
    {
        //Debug.Log("UInputID:" + posID[2] + "><" + "fingerID:" + fingerID + "||" + posID[0]);
        if ((int) posID[2] == fingerID)
        {
            fingerID = -1;
        }
    }
	
	void Update () 
	{
	
	}
}
