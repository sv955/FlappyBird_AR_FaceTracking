using UnityEngine;

/// <summary>
/// Handle player and hurdle collision detection
/// </summary>
/// 

public class CollisionDetection : MonoBehaviour
{
    [SerializeField]
    private GameController gameController;
    
    private void OnTriggerEnter(Collider other)
    {
        gameController.HandleGameOver();
    }
}
