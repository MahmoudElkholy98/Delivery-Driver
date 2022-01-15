using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverController : MonoBehaviour
{
    [Range(0,3)]
    [SerializeField] private float rotationSpeed = 0.2f;


    [Range(0, 3)]
    [SerializeField] private float movmentSpeed = 2f;

    void Start(){
        
    }

    void Update() {

        if (Input.GetKey(KeyCode.D)) {
            RotateDriver(-rotationSpeed);
        }
        if (Input.GetKey(KeyCode.A)) {
            RotateDriver(rotationSpeed);
        }

        if (Input.GetKey(KeyCode.W)) {
            DriverMovement(movmentSpeed);
        }

        if (Input.GetKey(KeyCode.S)) {
            DriverMovement(-movmentSpeed);
        }
    }

    private void RotateDriver(float _rotationSpeed) {
        this.transform.Rotate(0, 0, _rotationSpeed);
    }

    private void DriverMovement(float _movementSpeed) {
        this.transform.Translate(0, _movementSpeed, 0);
    }
}
