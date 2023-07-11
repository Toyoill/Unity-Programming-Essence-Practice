using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour {
    public float spinSpeed = 60f;

    void Update() {
        transform.Rotate(new Vector3(0f, spinSpeed * Time.deltaTime, 0f));
    }
}
