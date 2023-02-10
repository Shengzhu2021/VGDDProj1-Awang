using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    #region Editor Variable
    [SerializeField]
    private Vector3 m_Bounds;
    [SerializeField]
    private EnemySpawnInfo[] m_Enemies;
    #endregion

    #region Initialization
    private void Awake()
    {
        StartSpawning();
    }
    #endregion

    #region Spawn Methods
    public void StartSpawning()
    {
        for(int i = 0; i < m_Enemies.Length; i++)
        {
            StartCoroutine(Spawn(i));
        }
    }

    private IEnumerator Spawn(int enemeyInd)
    {
        EnemySpawnInfo info = m_Enemies[enemeyInd];
        int i = 0;
        bool alwaysSpawn = false;
        if (info.NumberToSpawn == 0)
        {
            alwaysSpawn = true;
        }
        while (alwaysSpawn || i < info.TimeToNextSpawn)
        {
            yield return new WaitForSeconds(info.TimeToNextSpawn);
            float xVal = m_Bounds.x / 2;
            float yVal = m_Bounds.y / 2;
            float zVal = m_Bounds.z / 2;
            Vector3 spawnPos = new Vector3(
                Random.Range(-xVal, xVal),
                Random.Range(-yVal, yVal),
                Random.Range(-zVal, zVal));

            spawnPos += transform.position;
            Instantiate(info.EnemyGO, spawnPos, Quaternion.identity);
            if (!alwaysSpawn)
            {
                i++;
            }
        }
    }
    #endregion
}
