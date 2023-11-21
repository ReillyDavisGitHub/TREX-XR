using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine;



public class CarController : MonoBehaviour


{


    public float speed = 10f;


    public float rotationSpeed = 100f;



    // Update is called once per frame


    void Update()


    {


        // Move the car forward and backward


        float verticalInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);



        // Rotate the car left and right


        float horizontalInput = Input.GetAxis("Horizontal");


        transform.Rotate(Vector3.up * horizontalInput * rotationSpeed * Time.deltaTime);


    }


}