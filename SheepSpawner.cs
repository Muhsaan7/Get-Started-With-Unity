using System.Threading;
using UnityEngine;

public class SheepSpawner : MonoBehaviour
{
    [SerializeField] GameObject sheepPrefab;
    [SerializeField] float spawnRange = 10f;
    [SerializeField]  float spawnInterval = 1f;
    float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer>spawnInterval)
        {
            float xPos = Random.Range(-spawnRange, spawnRange);
            Vector3 position = new Vector3(xPos, transform.position.y, transform.position.z);
            Instantiate(sheepPrefab, transform.position, sheepPrefab.transform.rotation);
            timer = 0f;
        }
    }
}
