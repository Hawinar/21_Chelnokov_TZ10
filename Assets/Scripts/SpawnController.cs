using System;
using UnityEngine;

public class SpawnConroller : MonoBehaviour
{
    [SerializeField] private GameObject _obstacle;

    private float _time;
    private float _timeBetweenSpawn = 5;

    void Update()
    {
        if (Time.time > _time)
        {
            Spawn();
            _time = Time.time + _timeBetweenSpawn;
        }
    }

    private void Spawn()
    {
        Instantiate(_obstacle, new Vector3(0, 15, 0), new Quaternion(0, 0, 0, 0));
    }
}
