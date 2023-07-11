using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour {
    public float minRate = 0.5f;
    public float maxRate = 3f;
    public GameObject bulletPrefab;

    private float spawnRate;
    private float timeAfterSpawn;
    private Transform target;

    void Start() {
        spawnRate = Random.Range(minRate, maxRate);
        timeAfterSpawn = 0f;
        target = FindObjectOfType<PlayerController>().transform;
    }

    void Update() {
        timeAfterSpawn += Time.deltaTime;

        if (spawnRate <= timeAfterSpawn) {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            spawnRate = Random.Range(minRate, maxRate);
            timeAfterSpawn = 0f;

            bullet.transform.LookAt(target);
        }
    }
}
