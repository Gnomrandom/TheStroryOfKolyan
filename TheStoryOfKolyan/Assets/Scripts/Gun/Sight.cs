using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Sight : MonoBehaviour
    {
        private Camera _camera;

        private void Awake()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10f;
            Vector3 aimPos = _camera.ScreenToWorldPoint(mousePos);
            transform.position = aimPos;
        }
    }
}