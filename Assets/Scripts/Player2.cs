using Assets.Scripts;
using UnityEngine;

namespace Arkanoid
{
    public class Player2 : MonoBehaviour, IBallCollisionHandler
    {
        private static Player2 _instance;
        public static Player2 Instance => _instance;
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
            Debug.Log("Collided with Player2 Platform");
        }
    }
}