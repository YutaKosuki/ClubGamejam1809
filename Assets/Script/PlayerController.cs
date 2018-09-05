using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 20;
    public GameObject gameOverGUI;
    public GameObject retryButton;

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

        this.enable = false;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground") {
            GameOver();
        } 

        this.enable = true;
    }

    void OnCollisionStay(Collision other)
    {
        this.enable = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal") {
            GameClear();
        }
    }

    void GameOver () {
        this.enable = false;
        gameOverGUI.SendMessage("GameOver");
        retryButton.SetActive(true);
    }

    void GameClear () {
        Debug.Log("Game Clear");
    }

    public void Retry () {
        this.gameObject.transform.position = new Vector3(0, 100, -536.1f);
        rb.velocity = Vector3.zero;
        gameOverGUI.SendMessage("Init");
        retryButton.SetActive(false);
    }
}
