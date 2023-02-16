using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    private float m_Damge;
    public float Damage
    {
        get
        {
            return m_Damge;
        }
    }

    [SerializeField]
    private float m_speed;
    #endregion

    #region Private Variables
    private float p_curHealth;
    #endregion

    #region Cached Components
    private Rigidbody cc_Rb;
    #endregion

    #region Cached References;
    private Transform cr_Player;
    #endregion

    #region Private Variables
    private Vector3 direction;
    #endregion

    #region Initialization
    private void Awake()
    { 
        cc_Rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        cr_Player = FindObjectOfType<PlayerController>().transform;
        Vector3 adjustingVector = new Vector3(0, 1, 0);
        direction = cr_Player.position - transform.position + adjustingVector;
        direction.Normalize();
        cc_Rb.MovePosition(cc_Rb.position + direction * m_speed * Time.fixedDeltaTime);
    }
    #endregion

    #region Main Updates
    private void FixedUpdate()
    {
        cc_Rb.MovePosition(cc_Rb.position + direction * m_speed * Time.fixedDeltaTime);
    }
    #endregion
}
