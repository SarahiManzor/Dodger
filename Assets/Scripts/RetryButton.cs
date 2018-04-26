using UnityEngine;
using System.Collections;

public class RetryButton : MonoBehaviour 
{	
	void OnTouchDown () 
	{
		Time.timeScale = 1;
		Application.LoadLevel("main");
	}
}
