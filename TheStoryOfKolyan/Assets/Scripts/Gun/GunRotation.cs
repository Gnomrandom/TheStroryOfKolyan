
using UnityEngine;

namespace Gun
{
    public class GunRotation: MonoBehaviour
    {
        private void Update()
        {
            var mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            var angle = Vector2.Angle(Vector2.right, mousePosition - transform.position);
            transform.eulerAngles = new Vector3(0f, 0f, transform.position.y < mousePosition.y ? angle : -angle);
        }
    }
}