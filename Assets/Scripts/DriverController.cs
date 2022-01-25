using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverController : MonoBehaviour
{
    [Range(0, 500)]
    [SerializeField] private float steerSpeed = 0.2f;


    [Range(0, 50)]
    [SerializeField] private float movmentSpeed = 2f;

    void Start(){
        
    }

    void Update() {

        if (Input.GetKey(KeyCode.D)) {
            SteerCar(-steerSpeed);
        }
        if (Input.GetKey(KeyCode.A)) {
            SteerCar(steerSpeed);
        }

        if (Input.GetKey(KeyCode.W)) {
            DriverMovement(movmentSpeed);
        }

        if (Input.GetKey(KeyCode.S)) {
            DriverMovement(-movmentSpeed);
        }
    }

    private void SteerCar(float _rotationSpeed) {
        float steerAmount = _rotationSpeed * Time.deltaTime;
        this.transform.Rotate(0, 0, steerAmount);
    }

    private void DriverMovement(float _movementSpeed) {
        float rotationAmount = _movementSpeed * Time.deltaTime;
        this.transform.Translate(0, rotationAmount, 0);
    }
}
