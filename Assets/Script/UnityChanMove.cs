using UnityEngine;
using System.Collections;

public class UnityChanMove : MonoBehaviour 
{

	private Animator animator;

	// Use this for initialization
	void Start () 
	{
		animator = GetComponent<Animator> ();	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey ("up")) 
		{
			transform.position += transform.forward * 0.05f;
			animator.SetBool ("isRunning", true);
		} 
		else 
		{
			animator.SetBool ("isRunning", false);
		}

		if (Input.GetKey ("right")) 
		{
			transform.Rotate (0, 5, 0);
		}
		if (Input.GetKey ("left")) 
		{
			transform.Rotate (0, -5, 0);
		}
	}
}
