using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitsForBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 13){
             transform.position = new Vector3(-11f, transform.position.y,transform.position.z);
         }
         else{
             if(transform.position.x < -13f){
             transform.position = new Vector3(11f, transform.position.y,transform.position.z);
          }
         }
         if(transform.position.y > 4.3f){
             transform.position = new Vector3(transform.position.x,-3.5f,transform.position.z);
         }
         if(transform.position.y < -4.3f){
             transform.position = new Vector3(transform.position.x,3.5f,transform.position.z);
         }
    }
}
