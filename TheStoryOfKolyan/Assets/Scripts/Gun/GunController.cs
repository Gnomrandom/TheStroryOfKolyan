using System.Collections.Generic;
using UnityEngine;

namespace Gun
{
    public class GunController: MonoBehaviour
    {
        private BulletState _bulletState;
        private KolyanControls _shotControls;
        [SerializeField] private List<GameObject> _bullets;

        private void Start()
        {
            _bulletState = BulletState.Default;
        }
        private void Awake()
        {
            _shotControls = new KolyanControls();
            _shotControls.main.Shoot.performed += ctx => Shot();
        }

        private void Shot()
        {
            switch (_bulletState)
            {
                case   BulletState.YourMouth:
                break;
                case   BulletState.YourAss:
                break;
                case   BulletState.YourTongue:
                break;
                case   BulletState.Default:
                break;
            }
        }
    }
}