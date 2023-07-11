using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody playerRigidbody;

    public float speed = 9f;

    // Start is called before the first frame update
    void Start() {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        playerRigidbody.velocity = new Vector3(x * speed, 0f, z * speed);
    }

    public void Die() {
        gameObject.SetActive(false);

        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}
