using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class main : MonoBehaviour
{

    public float spawn_speed = 1f;
    public GameObject asteroid;
    void Start()
    {
        InvokeRepeating("spawnAsteroids", 1f, spawn_speed);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void spawnAsteroids()
    {
        Debug.Log("Shot");
        Instantiate(asteroid, new Vector2(2, 3), Quaternion.identity);
    }
}
