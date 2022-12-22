using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// to fix intelisense  install developer pack and restart kolch a93d trestarti kolch ki files ki vs ki idk
public class Player : MonoBehaviour
{
    Rigidbody rb;

    public float speed;

    public float JumpForce ;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>(); 
        anim=GetComponent<Animator>();  
                                        
        
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Vertical");
        float moveVertical = Input.GetAxis("Horizontal");

        Moving(moveHorizontal, moveVertical);

        if(Input.GetKeyDown(KeyCode.Space)) Jump();

    }



    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Cube")) other.gameObject.GetComponent<Renderer>().material.color=Color.grey;
    }
    private void OnCollisionExit(Collision other) {
        if(other.gameObject.CompareTag("Cube"))  other.gameObject.GetComponent<Renderer>().material.color=Color.white;
    }



    private void Jump(){
        rb.AddForce(Vector3.up*JumpForce,ForceMode.Impulse);
    }
    private void Moving(float moveHorizontal, float moveVertical)
    {
        Vector3 movement = new Vector3(-1 * moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(force: movement * speed);

    }

    // public override int GetHashCode()
    // {
    //     return base.GetHashCode();
    // }

    // public override bool Equals(object other)
    // {
    //     return base.Equals(other);
    // }

    // public override string ToString()
    // {
    //     return base.ToString();
    // }
}
