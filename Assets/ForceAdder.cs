using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ForceAdder : MonoBehaviour
{

    [SerializeField] float forceSize = 10f;
    [SerializeField ]ForceMode2D forceMode = ForceMode2D.Force;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(new Vector3(0,0,forceSize) , forceMode);        
    }
}
