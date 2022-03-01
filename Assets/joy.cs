using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joy : MonoBehaviour
{
    Vector3 startpos;
    public float speed = 0.001f;
    private GameObject mysphere;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
        mysphere = GameObject.FindWithTag("mainball");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 change = transform.position - startpos;
        mysphere.GetComponent<Rigidbody> ().AddForce (-change.x/50*speed, 0,-change.y/50*speed);
       // print(change);

    }
}
