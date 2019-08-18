using System.Collections;
using UnityEngine;

public class SpawnBombs : MonoBehaviour {

    public GameObject[] asteroids;

    // максимальная скорость появление
    public float spawnWait;

    // Число астероидов в волне
    public int asteroidCount = 20;

    // Пауза между волнами
    public float waveWait;


    public int tb = 20;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            for (int i = 0; i < asteroidCount; i++)
            {
                GameObject asteroid = asteroids[Random.Range(0, asteroids.Length)];
                Instantiate(asteroid, new Vector2(Random.Range(-2.5f, 2.5f), 5.4f), Quaternion.identity);

                yield return new WaitForSeconds(Random.Range(0.3f, spawnWait));
            }
            if (asteroidCount < 70)
            {
                asteroidCount = asteroidCount + tb;
                spawnWait = spawnWait - 0.3f;
                yield return new WaitForSeconds(waveWait);
                tb = tb + 10;

            }
        }
    }
}

