using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnСycle: MonoBehaviour
{
    [SerializeField] private float _duration;

    private Spawner[] _spawners;

    private void Awake()
    {
        _spawners = gameObject.GetComponentsInChildren<Spawner>();
    }

    private void OnEnable()
    {
        StartCoroutine(SpawnEnemyes());
    }

    private IEnumerator SpawnEnemyes()
    {
        var wait = new WaitForSeconds(_duration);
        int spawnerIndex = 0;

        while (true)
        {
            if(spawnerIndex >= _spawners.Length)
                spawnerIndex = 0;
            _spawners[spawnerIndex].Spawn();
            spawnerIndex++;
            yield return wait;
        }
    }
}
