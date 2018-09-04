using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

 public float speed = 20;

    private Rigidbody rb;

    private bool enable;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        enable = true;
    }

    void Update()
    {
        if (this.enable) {
            var moveHorizontal = Input.GetAxis("Horizontal");
            var moveVertical = Input.GetAxis("Vertical");

            var movement = new Vector3(moveHorizontal, 0, moveVertical);

            rb.AddForce(movement * speed);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground") {
            GameOver();
        }
    }

    void GameOver () {
        this.enable = false;
        Debug.Log("GameOver");
    }
}
