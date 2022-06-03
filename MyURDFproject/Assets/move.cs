using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
	    // Adjust the speed for the application.
    public float speed = 10f;
    //public GameObject drilling;
        // The target (cylinder) position.
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
    //    transform.position = new Vector3(0.0f, 0.0f, 0.0f);
               // Grab cylinder values and place on the target.
        // target = drilling.transform;
        // target.transform.position = new Vector3(-0.8f, 0.0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
	            // Move our position a step closer to the target.
        var step =  speed * Time.deltaTime; // calculate distance to move
        // drilling.transform.position = Vector3.MoveTowards(transform.position, target.position,step);
    }
}
