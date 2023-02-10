using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerAttackInfo
{
    #region Editor Variables
    [SerializeField]
    private string m_Name;
    public string AttackName
    {
        get
        {
            return m_Name;
        }
    }

    [SerializeField]
    private string m_Button;
    public string Button
    {
        get
        {
            return m_Button;
        }
    }

    [SerializeField]
    private string m_TriggerName;
    public string TriggerName
    {
        get
        {
            return m_TriggerName;
        }
    }

    [SerializeField]
    private GameObject m_AbilityGO;
    public GameObject AbilityGO
    {
        get
        {
            return m_AbilityGO;
        }
    }

    [SerializeField]
    private Vector3 m_offset;
    public Vector3 Offset
    {
        get
        {
            return m_offset;
        }
    }

    [SerializeField]
    private float m_WindUpTime;
    public float WindUpTime
    {
        get
        {
            return m_WindUpTime;
        }
    }

    [SerializeField]
    private float m_FrozenTime;
    public float FrozenTime
    {
        get
        {
            return m_FrozenTime;
        }
    }

    [SerializeField]
    private float m_Cooldown;

    [SerializeField]
    private int m_HealthCost;
    public int HealthCost
    {
        get
        {
            return m_HealthCost;
        }
    }

    [SerializeField]
    private Color m_Color;
    public Color AbilityColor
    {
        get
        {
            return m_Color;
        }
    }
    #endregion

    #region Public Variables
    public float Cooldown
    {
        get;
        set;
    }
    #endregion

    #region CooLdown Methods
    public void ResetCooldown()
    {
        Cooldown = m_Cooldown;
    }
    public bool IsReady()
    {
        return Cooldown <= 0;
    }
    #endregion 
}
