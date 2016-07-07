using UnityEngine;
using System.Collections;

public class MoveBox : MonoBehaviour 
{

	public float speed = 0.05f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");
		transform.Translate (x * speed, 0, z * speed);
	}
}
