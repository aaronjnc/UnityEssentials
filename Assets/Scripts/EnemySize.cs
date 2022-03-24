using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySize : MonoBehaviour
{
    [Tooltip("Enemy Transform component")]
    private Transform enemyTransform;
    [Header("Size Information")]
    [Tooltip("Max size of enemy"), Range(0, 10)]
    public float maxSize = 3;
    [HideInInspector] public float waitSeconds = 5;
    private void Start()
    {
        enemyTransform = GetComponent<Transform>();
        StartCoroutine("ColorChanger");
    }
    IEnumerator ColorChanger()
    {
        float randomSize = UnityEngine.Random.Range(0, maxSize);
        enemyTransform.localScale = new Vector3(randomSize, randomSize, 1);
        yield return new WaitForSeconds(waitSeconds);
        StartCoroutine("ColorChanger");
    }
}
