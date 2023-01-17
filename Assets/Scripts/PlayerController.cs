
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

namespace Arkanoid
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private InputAction _moveInputAction;
        [SerializeField] private InputAction _launchInputAction;
        [SerializeField, Range(0, 10)] private float _movementSpeed;
        [SerializeField] private InputAction _pauseInputAction;
        
        private BallManager _ballManager;

        [SerializeField] private PauseController _menuPausePanel;

        private void Awake()
        {
            
            _ballManager = FindObjectOfType<BallManager>();
        }

        private void Update()
        {
           
            OnMovement();
        }

        private void OnPause(CallbackContext context)
        {
            _menuPausePanel.gameObject.SetActive(true);
        }

        private void OnMovement()
        {
            var direction = _moveInputAction.ReadValue<Vector2>();
            var velocity = new Vector3(direction.x, 0f, direction.y);
            transform.position += velocity * _movementSpeed * Time.deltaTime;
        }

        private void OnDestroy()
        {
            _moveInputAction.Dispose();
        }

        private void OnEnable()
        {
            _pauseInputAction.Enable();
            _pauseInputAction.performed += OnPause;
            _moveInputAction.Enable();
            _launchInputAction.Enable();
            _launchInputAction.performed += Launch;
        }

        private void OnDisable()
        {
            _pauseInputAction.performed -= OnPause;
            _pauseInputAction.Disable();
            _moveInputAction.Disable();
            _launchInputAction.Disable();
            _launchInputAction.performed -= Launch;
        }
        
        public void Launch(CallbackContext context)
        {
            _ballManager.Ball.SetDirection(Vector3.down);
            _ballManager.Ball.enabled= true;

            //GameManager.Instance.IsGameOn = true;

            Debug.Log("Ball is launched");
        }


    }
}