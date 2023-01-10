using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class BallMover : MonoBehaviour
    {
        private Vector3 _direction;
        private float _speed = 5f;


        [SerializeField, Range(1, 10)] private float _speedStep;
        [SerializeField, Range(1, 100)] private float _maxSpeed;


        private void Update()
        {
            transform.Translate(_direction * _speed * Time.deltaTime);
        }

        private void OnCollisionEnter(Collision coll)//colliding method
        {
            _speed += _speedStep;
            _speed = Mathf.Clamp(_speed, 0f, _maxSpeed);

            _direction = Vector3.Reflect(_direction, coll.contacts[0].normal);

                        

            if (coll.collider.TryGetComponent(out IBallCollisionHandler handler))//colliding with player platforms
            {

                handler.Handle(this);

            }

        }

        public void SetDirection(Vector3 direction)
        {
            _direction = direction;
        }
    }
}