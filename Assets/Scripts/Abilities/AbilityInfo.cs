using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AbilityInfo
{
    #region Editor Variables
    [SerializeField]
    private int m_Power;
    public int Power
    {
        get
        {
            return m_Power;
        }
    }

    [SerializeField]
    private int m_Range;
    public int Range
    {
        get
        {
            return m_Range;
        }
    }
    #endregion
}
