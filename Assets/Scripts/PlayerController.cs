using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody2D rb2d;
    private float horizontalMove = 0f;

    public CharacterController2D controller;
    public float runSpeed;

    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update() {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        Debug.Log(horizontalMove);
    }

    void FixedUpdate() {
        controller.Move(horizontalMove, false, false);
    }
}
