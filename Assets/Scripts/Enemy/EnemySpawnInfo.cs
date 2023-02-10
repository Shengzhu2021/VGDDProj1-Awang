using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemySpawnInfo
{
    #region Editor Variable
    [SerializeField]
    private string m_Name;
    public string Name
    {
        get
        {
            return m_Name;
        }
    }
    [SerializeField]
    private GameObject m_EnemyGo;
    public GameObject EnemyGO
    {
        get
        {
            return m_EnemyGo;
        }
    }
    [SerializeField]
    private float m_TimeToNextSpawn;
    public float TimeToNextSpawn
    {
        get
        {
            return m_TimeToNextSpawn;
        }
    }
    [SerializeField] 
    private int m_NumberToSpawn;
    public int NumberToSpawn
    {
        get
        {
            return m_NumberToSpawn;
        }
    }
    #endregion
}
