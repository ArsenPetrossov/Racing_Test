using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform _target;

    [SerializeField] private float _lerp;
    private Vector3 _distance;
    
    void Start()
    {

        _target = FindObjectOfType<Move>().transform;
        _distance = transform.position - _target.position;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = _distance + _target.position;
       
    }
}