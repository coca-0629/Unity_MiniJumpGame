using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject pf_wall;
    //public float interval = 1.5f;     // delete

    // Use this for initialization
    IEnumerator Start()
    {
        while(true) {
            pf_wall.name = "pf_wall";
            float interval_rnd = Random.Range(1.0f, 2.0f);
            float height_rnd = Random.Range(-3.0f, 4.0f);
            transform.position = new Vector3(10, height_rnd, 0);
            pf_wall = Instantiate(pf_wall, transform.position, transform.rotation);
            yield return new WaitForSeconds(interval_rnd);
            //Instantiate(pf_wall, transform.position, transform.rotation);
            //yield return new WaitForSeconds(interval);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
