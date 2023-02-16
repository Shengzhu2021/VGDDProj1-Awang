using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("the number of projectile fired persecond")]
    private float projectileRateOfFire;

    [SerializeField]
    [Tooltip("the projectile fired by the enemy")]
    private GameObject ProjectilePrefab;

    [SerializeField]
    [Tooltip("time before firing")]
    private int TimeToFire;
    #endregion

    #region Private Variables
    private float fireTimer;
    #endregion

    #region Cached Components
    private Rigidbody cc_Rb;
    #endregion

    #region Initialization
    private void Awake()
    {
        // Initialize the fire timers 
        fireTimer = TimeToFire;
        cc_Rb = GetComponent<Rigidbody>();
    }
    #endregion

    // Update is called once per frame
    void Update()
    {
        if (fireTimer <= 0)
        {
            Vector3 adjustingVector = new Vector3(0, 1, 0);
            Instantiate(ProjectilePrefab, cc_Rb.transform.position + adjustingVector, Quaternion.identity);
            fireTimer = 1 / projectileRateOfFire;
        } else if (fireTimer > 0)
        {
            fireTimer -= Time.deltaTime;
        }
    }
}
