using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public GameObject gameoverText;
    public Text scoreText;
    public Text recordText;

    private float surviveTime;
    private bool isDead;

    // Start is called before the first frame update
    void Start() {
        surviveTime = 0f;
        isDead = false;
    }

    // Update is called once per frame
    void Update() {
        if (!isDead) {
            surviveTime += Time.deltaTime;
            scoreText.text = "Time: " + (int)Mathf.Floor(surviveTime);
        } else {
            if (Input.GetKey(KeyCode.R)) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

    }

    public void EndGame() {
        isDead = true;
        gameoverText.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat("BestTime");
        if (surviveTime > bestTime) {
            bestTime = surviveTime;
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }
        recordText.text = "Best Time: " + (int)bestTime;

    }
}
