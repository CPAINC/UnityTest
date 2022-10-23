using UnityEngine;

public class MoveCube : MonoBehaviour
{
    private float moveSpeed;
    private float distance;
    public float timerSpawn;
    private float startPoint;

    private Canvas mainCanvas;
    private SpawnCube spawner;

    void Start()
    {
        spawner = FindObjectOfType<SpawnCube>();
        mainCanvas = FindObjectOfType<Canvas>();
        moveSpeed = Random.Range(1, 3);
        distance = Random.Range(3, 6);
        startPoint = transform.position.z;
        mainCanvas.UpdateInformationLastCube(distance, moveSpeed, timerSpawn);
    }

    void Update()
    {
        if (distance + startPoint >= transform.position.z)
        {
            transform.Translate(moveSpeed * Time.deltaTime * Vector3.forward);
        }
        else
        {
            Destroy(transform.gameObject);
            spawner.ResetTheTimer();
        }
    }
}
