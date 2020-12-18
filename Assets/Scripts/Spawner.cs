using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyForSpawn;

    public void Spawn()
    {
        Enemy enemy = Instantiate(_enemyForSpawn, transform.position, Quaternion.identity);
    }
}