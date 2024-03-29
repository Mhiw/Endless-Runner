using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	[Header("Stats")]
	[SerializeField] private float jumpForce;

	[Header("Keys")]
	[SerializeField] private KeyCode jumpKey;

	private Rigidbody2D rb;

    private void Start() {
		rb = GetComponent<Rigidbody2D>();        
    }

	private void Update() {
		if(Input.GetKeyDown((jumpKey))) {
			rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
		}
	}
}
