using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    public float speed = -5;

    void Start()
    {
        float speed_rnd = Random.Range(-1.0f, 1.0f);    // add
        speed = speed + speed_rnd;                      // add

        // Kills the game object in 5 seconds after loading the object
        // Destroy(gameObject, 5.0f);
        Destroy(gameObject, 6.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
