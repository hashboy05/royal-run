using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] float checkpointTimeExtension = 5f;
    GameManager gameManager;
    ObstacleSpawner obstacleSpawner;
    const string playerString = "Player";
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
        obstacleSpawner = FindFirstObjectByType<ObstacleSpawner>();
    }
    void OnTriggerEnter(Collider other){
        if (other.CompareTag(playerString)){
            gameManager.IncreaseTime(checkpointTimeExtension);
            obstacleSpawner.DecreaseObstacleSpawnTime(0.2f);
        }
    }
}
