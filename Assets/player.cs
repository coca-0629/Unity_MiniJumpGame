using static System.Math;                       // add
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public Texture2D icon1 = null;              // add
    public Texture2D icon2 = null;              // add
    // public float jump_power = 15;
    public float jump_power = 4.0f;
    private float time_record = 0.0f;           // add
    
    // add function
    void Start()
    {
        float jump_plus_rnd = Random.Range(0.0f, 5.0f);
        jump_power = (float)Round(jump_power + jump_plus_rnd, 3);

        time_record = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Jump"))
            GetComponent<Rigidbody>().velocity = new Vector3(0, jump_power, 0);
    }

    void OnCollisionEnter(Collision other) {
        SceneManager.LoadScene("main_scene");
    }

    // add function
    void OnGUI() {
        GUI.DrawTexture (new Rect(0, Screen.height - 64, 64, 64), icon1);
        GUI.Label(new Rect(81, Screen.height - 40, 128, 32), "Jump Power: " + jump_power.ToString());

        GUI.DrawTexture (new Rect(Screen.width - 64, Screen.height - 64, 64, 64), icon2);
        GUI.Label(new Rect(Screen.width - 185, Screen.height - 40, 128, 32), "Survive Time : " + Round(Time.time - time_record, 3).ToString());
    }
}
