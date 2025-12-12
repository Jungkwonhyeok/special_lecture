using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TerrainUtils;

namespace P1NGMU
{
    public class GameManager : MonoBehaviour
    {
        public GameObject[] Enemys;
        public Vector3 spawnValue;
        public int enemyCount;
        public List<GameObject> listEnemys = new List<GameObject>();

        public float spawnWait;
        public float startWait;
        public float waveWait;

        void Start()
        {
            StartCoroutine(SpawnEnemy());
        }

        IEnumerator SpawnEnemy()
        {
            yield return new WaitForSeconds(spawnWait);
            while (true)
            {
                for(int i = 0; i < enemyCount; i++)
                {
                    GameObject enemy = Enemys[Random.Range(0, Enemys.Length)];
                    Vector3 spawnPosition = new Vector3(Random.Range(-spawnValue.x, spawnValue.x), spawnValue.y, spawnValue.z);
                    Quaternion spawnRotatation = Quaternion.identity;
                    listEnemys.Add(Instantiate(enemy, spawnPosition, enemy.transform.rotation));
                    yield return new WaitForSeconds(spawnWait);

                }
                yield return new WaitForSeconds(waveWait);
            }
        }
    }
}
