using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour {

	static Rigidbody rb;
	public static Vector3 diceVelocity;

	// Torqu 힘과 Force 에 가해지는 힘
	private int power = 500;
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	void Update ()
	{
		Dice();
	}

	/// <summary>
	/// 주사위를 굴려 x,y,z 의 값을 0 ~499 까지 position을 랜덤으로 정하고 addForce를 통해 위로 튕기는 기능
	/// </summary>
	private void Dice()
	{
		diceVelocity = rb.velocity;

		if (Input.GetKeyDown (KeyCode.Space)) {
			DiceNumberTextScript.diceNumber = 0;
			float dirX = Random.Range (0, power);
			float dirY = Random.Range (0, power);
			float dirZ = Random.Range (0, power);
			transform.position = new Vector3 (0, 2, 0);
			transform.rotation = Quaternion.identity;
			rb.AddForce (transform.up * power);
			// 회전에 힘을 주는 기능
			rb.AddTorque (dirX, dirY, dirZ);
		}
	}
}
