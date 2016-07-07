﻿using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour 
{
	// 移動速度
	public float speed = 15.0F;

	// ジャンプ速度
	public float jumpSpeed = 8.0F;

	// 重力の設定
	public float gravity = 20.0F;

	// ベクトルの方向
	private Vector3 moveDirection = Vector3.zero;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{

		// プレイヤーの移動
		CharacterController controller = GetComponent<CharacterController>();

		if (controller.isGrounded) 
		{
			moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
			moveDirection = transform.TransformDirection (moveDirection);
			moveDirection *= speed;

			if (Input.GetButton ("Jump")) 
			{
				moveDirection.y = jumpSpeed;
			}
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move (moveDirection * Time.deltaTime);
	}
}
