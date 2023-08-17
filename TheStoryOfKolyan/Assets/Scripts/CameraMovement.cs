using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{   
    private Camera _camera;
    [SerializeField] private Transform _playerTransform;
    
    void Start()
    {
        _camera = Camera.main;
    }

    void Update()
    {
        var position = _playerTransform.position;
        var transform1 = _camera.transform;
        transform1.position= new Vector3(position.x, transform1.position.y, transform1.position.z);
    }
}
