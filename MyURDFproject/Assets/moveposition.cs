using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveposition : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}
	
    // Adjust the speed for the application.
    public float speed = 10f;

    // The target (cylinder) position.
    private Transform target;
    private GameObject cylinder;

    void Awake()
    {
        // // Position the cube at the origin.
        // transform.position = new Vector3(0.0f, 0.0f, 0.0f);

        // // Create and position the cylinder. Reduce the size.
        // cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        // Debug.Log("cylinder: " + cylinder);
        // cylinder.transform.localScale = new Vector3(0.15f, 1.0f, 0.15f);

        // // Grab cylinder values and place on the target.
        // target = cylinder.transform;
        // target.transform.position = new Vector3(-0.8f, 0.0f, 1f);

        // // Position the camera.
        // Camera.main.transform.position = new Vector3(0.85f, 1.0f, -3.0f);
        // Camera.main.transform.localEulerAngles = new Vector3(15.0f, -20.0f, -0.5f);

        // // Create and position the floor.
        // GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Plane);
        // floor.transform.position = new Vector3(0.0f, -1.0f, 0.0f);
    }

    void Update()
    {
        // // Move our position a step closer to the target.
        // var step =  speed * Time.deltaTime; // calculate distance to move
        // // Debug.Log("step: " + step);
        // // Debug.Log("Time.deltaTime: " + Time.deltaTime);
        // // cylinder.enabled = false;
        // // transform.position = Vector3.MoveTowards(transform.position, target.position,step);
        // transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * speed);
        // // cylinder.enabled = true;
        // // Debug.Log("Transform.Position" + transform.position);

        // // Check if the position of the cube and sphere are approximately equal.
        // if (Vector3.Distance(transform.position, target.position) < 0.001f)
        // {
        //     // Swap the position of the cylinder.
        //     target.position *= -1.0f;
        // }
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
