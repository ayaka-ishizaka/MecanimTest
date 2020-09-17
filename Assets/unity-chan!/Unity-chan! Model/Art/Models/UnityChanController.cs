using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour {
	private Rigidbody myRigidbody;
	//前身のスピード
	private float forwardForce = 200.0f;
	//方向転換のスピード
	float angleSpeed = 150;

	// Use this for initialization
	void Start () {
		this.myRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		//上矢印キーを押し続けた場合
		if (Input.GetKey(KeyCode.UpArrow)) {
			//Animatorコンポーネントを取得し、"RunTrigger"をtrueにする
			GetComponent<Animator> ().SetTrigger ("RunTrigger");
			//前進する
			this.myRigidbody.AddForce (this.transform.forward * this.forwardForce);
		}

		//左右キーで方向転換
		float Angle = Input.GetAxisRaw("Horizontal") * Time.deltaTime * angleSpeed;
		transform.Rotate(Vector3.up * Angle);
	}
}
