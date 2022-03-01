using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballmove : MonoBehaviour
{
    public float xForce = 100.0f;  
    public float zForce = 10.0f;  
    public float yForce = 50.0f;  
    private Vector3 temp;
    private bool canjump= false;

    public void moveleft()
    {
        float x = 0.0f;
        x = x - xForce; 
        GetComponent<Rigidbody> ().AddForce (x, 0, 0);   
        print("moveleft");
    }
    public void moveright()
    {
        float x = 0.0f;
        x = x + xForce; 
        GetComponent<Rigidbody> ().AddForce (x, 0, 0);   
        print("moveright");
    }
    public void moveup()
    {
        
       float z = 0.0f;
  
            z = z + zForce;  
        GetComponent<Rigidbody> ().AddForce (0, 0, z);   
    }
    public void movedown()
    {
        
       float z = 0.0f;
  
            z = z - zForce;  
        GetComponent<Rigidbody> ().AddForce (0, 0, z);   
    }
    public void jump()
    {
        float y = 0.0f;
       
            y = yForce;
         
  
        GetComponent<Rigidbody> ().AddForce (0, y, 0);  
    }
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "ground" )
            { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
             }
    }
    void Update () {  
      
     print(canjump);
       
        
           
       
    
  
      
     
        
    }  

   
     
}