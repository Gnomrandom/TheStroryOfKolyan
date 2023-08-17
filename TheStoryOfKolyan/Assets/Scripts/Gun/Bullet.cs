using System.Collections.Generic;
using UnityEngine;

namespace Gun
{
    public class Bullet : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Destroy(gameObject);
        }
    }
}