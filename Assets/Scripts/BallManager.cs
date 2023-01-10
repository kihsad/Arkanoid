using Assets.Scripts;
using UnityEngine;

namespace Arkanoid
{
    public class BallManager : MonoBehaviour
    {
        [SerializeField]
        private BallMover ballPrefab;
       
        public BallMover Ball { get; private set; }
                
        private static BallManager _instance;
        public static BallManager Instance => _instance;
        

        public void Awake()
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

        public void Start()
        {
            InstantiateBall();
            
        }
       
        private void InstantiateBall()
        {
            Vector3 playerPosition = Player1.Instance.gameObject.transform.position;
            Vector3 startingPosition = new Vector3(playerPosition.x, playerPosition.y-2f, playerPosition.z);
            Ball = Instantiate(ballPrefab, startingPosition, Quaternion.identity);
                        
            Debug.Log("Ball is created");

        }



      
    }
}