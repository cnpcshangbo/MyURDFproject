using UnityEngine;
using System.Collections;

public class ExampleBehaviourScript : MonoBehaviour
{
    void FixedUpdate ()
    {
        // Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer> ().material.color = Color.red;
            Debug.Log(transform.position.x);
            transform.Translate(new Vector3(0,0,0.1f));
            // transform.position;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
            transform.Translate(new Vector3(0,0.1f,0));
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
            transform.Translate(new Vector3(0.1f,0,0));
        }
    }
}