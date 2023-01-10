using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Arkanoid 
{
    public class BlocksController : MonoBehaviour, IBallCollisionHandler
    {
        [SerializeField] public Object _sphericalBlock;

        public void Handle(BallMover ball)
        {
            Debug.Log("Collided with Block");

            Destroy(gameObject);
        }

    }

}


