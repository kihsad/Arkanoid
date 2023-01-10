using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Arkanoid 
{
    public class TubeController : MonoBehaviour, IBallCollisionHandler
    {

        public void Handle(BallMover ball)
        {
            Debug.Log("Collided with Tube Wall");
        }

    }


}

