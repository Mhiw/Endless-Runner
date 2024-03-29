using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	[Header("Stats")]
	[SerializeField] private float f_jumpForce;
	
	//[Header("Refrences")]
	
	[Header("Keys")]
	[SerializeField] private KeyCode k_jumpKey;

	private Rigidbody2D r_rb;
	private bool b_isGrounded;

    private void Start() {
		r_rb = GetComponent<Rigidbody2D>();        
    }

	private void Update() {
		if(Input.GetKeyDown((k_jumpKey)) && b_isGrounded) {
			r_rb.AddForce(transform.up * f_jumpForce, ForceMode2D.Impulse);
		}
	}

	void OnTriggerStay(Collider other) {
		if(other.CompareTag("Ground")) {
			b_isGrounded = true;
			print("hola");
		} else {
			b_isGrounded = false;
		}
	}
}
