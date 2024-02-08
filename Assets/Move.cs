using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Transform _car;

    [SerializeField] private float _speed; // Используйте float для скорости
    [SerializeField] private float _rotationSpeed; // Скорость вращения

    // Start is called before the first frame update
    void Start()
    {
        _car = this.transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 rotateDirection = new Vector3(0, horizontalInput, 0);

        Vector3 movement = new Vector3(0.0f, 0.0f, verticalInput);
        _car.Translate(movement * _speed * Time.fixedDeltaTime);

        if (movement != Vector3.zero)
        {
            _car.RotateAround(this.transform.position,rotateDirection,_rotationSpeed * Time.fixedDeltaTime);
        }
    }
}