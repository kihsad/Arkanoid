using Assets.Scripts;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Arkanoid
{
    public class LimitController : MonoBehaviour, IBallCollisionHandler
    {
        public void Handle(BallMover ball)
        {
            ball.enabled = false;

            Debug.Log("Collided with Limit Wall");

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

