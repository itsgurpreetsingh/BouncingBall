using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField]//used to show in inspector mode
    private float BallSpeed=100f;
    Rigidbody rb;//Made an instance of rigidbody //used to apply laws of physics on it
    
    // Start is called before the first frame update
    void Awake()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement=new Vector3(-Input.acceleration.x,Input.acceleration.y,Input.acceleration.z);//Vector3 as we are using in 3D .Vector2 for 2D
        rb.AddForce(movement*BallSpeed*Time.deltaTime);//To give movement to any object.We have to give speed along with direction as argument.
        //Time.deltaTime->So that it works on different devices smoothly.
    }
}