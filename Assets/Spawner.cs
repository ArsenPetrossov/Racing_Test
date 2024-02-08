using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _car;
    void Start()
    {
        Instantiate(_car,transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
