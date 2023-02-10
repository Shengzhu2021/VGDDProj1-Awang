using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    private int m_MaxHealth;

    [SerializeField]
    private float m_Damge;

    [SerializeField]
    private float m_HealthPillDropRate;

    [SerializeField]
    private GameObject m_HealthPill;

    [SerializeField] 
    private float m_speed;

    [SerializeField]
    private ParticleSystem m_DeathExplosion;

    [SerializeField]
    private int m_Score;
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

    #region Initialization
    private void Awake()
    {
        p_curHealth = m_MaxHealth;
        cc_Rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        cr_Player = FindObjectOfType<PlayerController>().transform;
    }
    #endregion

    #region Main Updates
    private void FixedUpdate()
    {
        Vector3 dir = cr_Player.position - transform.position;
        dir.Normalize();
        cc_Rb.MovePosition(cc_Rb.position + dir * m_speed * Time.fixedDeltaTime);
    }
    #endregion

    #region Collision Mechods
    private void OnCollisionStay(Collision collision)
    {
        GameObject other = collision.collider.gameObject;
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerController>().DecreaseHealth(m_Damge);
        }
    }
    #endregion

    #region Health Methods
    public void DecreaseHealth(float amount)
    {
        p_curHealth -= amount;
        if (p_curHealth <= 0)
        {
            ScoreManager.singleton.IncreaseScore(m_Score);
            if (Random.value < m_HealthPillDropRate)
            {
                Instantiate(m_HealthPill, transform.position, Quaternion.identity);
            }
            Instantiate(m_DeathExplosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    #endregion
}
