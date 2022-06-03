using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using System;

public class movedrone : MonoBehaviour
{
    // private const float V = 0.36f;
    public GameObject drone;
    public float altitude = 0.36f;
    private float altitude_error;
    public float max_speed;
    public float altitude_rate;
    public float altitude_speed;
    // Start is called before the first frame update
    void Start()
    {
        drone = GameObject.FindGameObjectWithTag("drone");
        altitude = 0.4f;
        max_speed = 0.01f;
        altitude_rate = 0.01f;
        altitude_speed = 0.001f;
    }
    void FixedUpdate()
    {
        // if (Input.GetKey(KeyCode.G))
        {
            Debug.Log("drone.transform.position.y: " + drone.transform.position.y);
            Debug.Log("altitude: " + altitude);
            altitude_error=drone.transform.position.y - altitude;
            if ((altitude_error > 0.01f) ^ (altitude_error < -0.01f))
            {
                drone.SetActive(false);
                // altitude = altitude + 0.1f;
                float cmd = -altitude_error;
                if (cmd > altitude_rate) cmd = altitude_rate;
                if (cmd < -altitude_rate) cmd = -altitude_rate;
                drone.transform.Translate(new Vector3(0,cmd,0));
                // drone.transform.rotation = new Vector3(0,0,0);
                drone.transform.eulerAngles = new Vector3(
                    0,
                    0,
                    0
                );
                // GetComponent<Renderer> ().enabled = true;
                drone.SetActive(true);
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // GetComponent<Renderer> ().material.color = Color.red;
            // Debug.Log(transform.position.x);
            drone.SetActive(false);
            drone.transform.Translate(new Vector3(-max_speed, 0,0));
            // GetComponent<Renderer> ().enabled = true;
            drone.SetActive(true);

            // transform.position;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // GetComponent<Renderer>().material.color = Color.green;
            // transform.Translate(new Vector3(0,0.1f,0));
            drone.SetActive(false);
            drone.transform.Translate(new Vector3(max_speed, 0,0));
            // GetComponent<Renderer> ().enabled = true;
            drone.SetActive(true);

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // GetComponent<Renderer>().material.color = Color.blue;
            // transform.Translate(new Vector3(0.1f,0,0));
            drone.SetActive(false);
            // altitude = altitude + 0.1f;
            drone.transform.Translate(new Vector3(0,0, max_speed));
            // GetComponent<Renderer> ().enabled = true;
            drone.SetActive(true);


        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // GetComponent<Renderer>().material.color = Color.blue;
            // transform.Translate(new Vector3(0.1f,0,0));
            drone.SetActive(false);
            // altitude = altitude - 0.1f;
            drone.transform.Translate(new Vector3(0,0,-max_speed));
            // GetComponent<Renderer> ().enabled = true;
            drone.SetActive(true);


        }

        if (Input.GetKey(KeyCode.W))
        {
            // GetComponent<Renderer>().material.color = Color.blue;
            // transform.Translate(new Vector3(0.1f,0,0));
            // drone.SetActive(false);
            // transform.Translate(new Vector3(0,-0.1f,0));
            // // GetComponent<Renderer> ().enabled = true;
            // drone.SetActive(true);
            altitude = altitude + altitude_speed;


        }
        if (Input.GetKey(KeyCode.S))
        {
            // GetComponent<Renderer>().material.color = Color.blue;
            // transform.Translate(new Vector3(0.1f,0,0));
            // drone.SetActive(false);
            // transform.Translate(new Vector3(0,0.1f,0));
            // // GetComponent<Renderer> ().enabled = true;
            // drone.SetActive(true);
            altitude = altitude - altitude_speed;

        }
    }
}
