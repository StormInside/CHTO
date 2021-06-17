using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class main : MonoBehaviour
{
    public float spawn_speed = 1;
    public GameObject asteroid;


    // public float[] posible_movement_x = { 1, 6 };
    // public float[] posible_movement_y = { 1, 6 };

    // public float posible_spawn_x_first = -10.0f;
    // public float posible_spawn_x_last = 10;
    // public float posible_spawn_y_first = 9;
    // public float posible_spawn_y_last = 10;

    public float asteroid_speed = 5;


    void Start()
    {
        InvokeRepeating("spawnAsteroids", 1, spawn_speed);

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void spawnAsteroids()
    {   
        var spawn_x = Random.Range(-5.0f, 5.0f);
        var spawn_y = Random.Range(9, 10);

        var rotation = Random.Range(0, 360);

        Instantiate(asteroid, new Vector2(spawn_x, spawn_y), Quaternion.Euler(0, 0, rotation));
    }
}
