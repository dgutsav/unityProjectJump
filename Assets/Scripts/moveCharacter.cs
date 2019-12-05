using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody body;
    public float input_press = 100f;
    public float jump  = 1000f;
    public float forward = 10000f;
    public Player player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A)){
            body.AddForce(-input_press*Time.deltaTime,0,0);
        }
        else if(Input.GetKey(KeyCode.D)){
            body.AddForce(input_press*Time.deltaTime,0,0);
        }
        else if(Input.GetKey(KeyCode.W)){
            body.AddForce(0,0,forward*Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            if(player.jump2Enable){
                player.jump2Enable = false;
                body.AddForce(0,jump*Time.deltaTime,0);
            }
            else if(player.jumpEnable){
                player.jumpEnable = false;
                body.AddForce(0,jump*Time.deltaTime,0);
            }
            else if(!player.jumpEnable && !player.jump2Enable){
                return;
            }
            
        }
    }
}
