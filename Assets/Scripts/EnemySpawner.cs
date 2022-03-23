using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Tooltip("Enemy prefab")]
    [SerializeField] private GameObject enemy = null;
    [Tooltip("Enemy parent transform")]
    [SerializeField] private Transform parent = null;
    /// <summary>
    /// Spawns enemy prefab into scene
    /// </summary>
    public void SpawnEnemy()
    {
        Instantiate(enemy, parent);
    }
}
