using System.Collections;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    public float timerSpawn;
    void Start()
     {
         StartCoroutine(SpawnNewCube());
     }
    private void Update()
    {
        timerSpawn += Time.deltaTime;
    }

    IEnumerator SpawnNewCube() // Create a new cube when it is not on the scene
    {
         if (!FindObjectOfType<MoveCube>())
         {
             GameObject cube = Instantiate(Resources.Load("Cube") as GameObject);
            cube.GetComponent<MoveCube>().timerSpawn = timerSpawn;
            ResetTheTimer();
         }
         yield return new WaitForSeconds(1);
        StartCoroutine(SpawnNewCube());
    }

    public void ResetTheTimer() // Reset the cube creation time timer
    {
        timerSpawn = 0;
    }
}