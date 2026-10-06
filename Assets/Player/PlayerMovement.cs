using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody RB;
    public float FrontForce = 2000f;
    public float SideForce = 200f;
    public float BackForce = 200f;

    void Start()
    {
        RB.useGravity = false; 
        
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //dopredu
        if (Input.GetKey("w"))
        {
            RB.AddForce(0, 0, -FrontForce* Time.deltaTime);

        }
        
        //vlevo
        if (Input.GetKey("a"))
        {
            RB.AddForce(SideForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        //vpravo
        if (Input.GetKey("d"))
        {
            RB.AddForce(-SideForce*Time.deltaTime, 0 , 0, ForceMode.VelocityChange) ;
        }
        
        //dozadu
        if (Input.GetKey("s"))
        {
            RB.AddForce(0, 0, BackForce *Time.deltaTime);
        }

            
            

        
    }
}
