using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPill : MonoBehaviour
{
    #region Editor Variable
    [SerializeField]
    private int m_HealthGain;
    public int HealthGain
    {
        get
        {
            return m_HealthGain;
        }
    }
    #endregion
}
