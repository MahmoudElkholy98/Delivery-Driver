using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [Range(0,3)]
    [SerializeField] private float rotationSpeed = 0.2f;

    void Start(){
        
    }

    void Update() {

        if (Input.GetKey(KeyCode.D)) {
            RotateDriver(-rotationSpeed);
        }
        if (Input.GetKey(KeyCode.A)) {
            RotateDriver(rotationSpeed);
        }
    }

    private void RotateDriver(float RotationAmount) {
        this.transform.Rotate(0, 0, RotationAmount);
    }
}
