using Assets.Scripts;
using UnityEngine;

namespace Arkanoid
{
    public class Player1 : MonoBehaviour, IBallCollisionHandler
    {
        private static Player1 _instance;
        public static Player1 Instance => _instance;
        private void Awake()
        {
            if (_instance != null)
            {
                Destroy(gameObject);
            }
            else
            {
                _instance = this;
            }
        }

        public void Handle(BallMover ball)
        {
            Debug.Log("Collided with Player1 Platform");
        }
    }
}