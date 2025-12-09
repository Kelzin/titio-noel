using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject monsterPrefab;
    [SerializeField] private float enemyInterval = 2f;

    void Start()
    {
        StartCoroutine(spawnEnemy(enemyInterval, monsterPrefab));
    }
private IEnumerator spawnEnemy(float interval, GameObject enemy)
{
    yield return new WaitForSeconds(interval);

    if (enemy == null)
    {
        Debug.LogError("O prefab do inimigo foi destruído!");
        yield break;
    }

    Instantiate(enemy, 
        new Vector3(Random.Range(-5f, 5f), Random.Range(-6f, 6f), 0f),
        Quaternion.identity);
    
    StartCoroutine(spawnEnemy(interval, enemy));
}



    void Update()
    {
        
    }
}
