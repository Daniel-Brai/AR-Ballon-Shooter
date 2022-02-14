﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBallon : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] ballons;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning() {

        yield return new WaitForSeconds(4);

        for ( int i = 0; i < 3; i++) {

            Instantiate(ballons[i], spawnPoints[i].position, Quaternion.identity);
        }

        StartCoroutine(StartSpawning());



    }
}
