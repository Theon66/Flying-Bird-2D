using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClonerScript : MonoBehaviour
{
    // 敌人生成点列表
    public List<GameObject> clonerPoints;
    public GameObject[] enemyPrefab;
    public float intervalTime;

    void Start()
    {
    }

    public void SpawnEnemy()
    {
        StartCoroutine(Clone());
    }

    IEnumerator Clone()
    {
        while (true)
        {
            Instantiate(enemyPrefab[Random.Range(0, enemyPrefab.Length)].gameObject, 
                clonerPoints[Random.Range(0, clonerPoints.Count)].transform.position,
                Quaternion.identity);
            yield return new WaitForSeconds(intervalTime);
        }
    }
}
