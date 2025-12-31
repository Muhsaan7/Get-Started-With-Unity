using UnityEngine;

public class SheepDestroyer : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
     void OnTriggerEnter(Collider other )
    {
        if(other.gameObject.CompareTag("Sheep"));
        {
            gameManager.LostSheep();
            Destroy(other.gameObject);
        }
    }
}
