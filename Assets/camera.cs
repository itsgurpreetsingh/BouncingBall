using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    [SerializeField]
    private Transform target;//Transform gives us the value of position,rotation,scale etc.
    [SerializeField]
    private float smoothSpeed=5f;
    Vector3 offset;//Distance between two objects i.e. here between camera and ball. 
    // Start is called before the first frame update
    void Start()
    {
        offset=transform.position-target.position;//Ball to camera distance
    }

    // Update is called once per frame
    
    //Find difference between Update,LateUpdate,FixedUpdate
    //CameraWork:LateUpdate; PhysicsWork:FixedUpdate
    void LateUpdate()//We do LateUpdate to make our camera work in smooth way.
    {
        Vector3 targetCampos=target.position+offset;
        transform.position=Vector3.Lerp(transform.position,targetCampos,smoothSpeed*Time.deltaTime);
        transform.LookAt(target);//Camera will be looking at our target i.e. ball here.
    }
}