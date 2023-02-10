using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    private Transform m_PlayerTransforms;

    [SerializeField]
    private Vector3 m_Offset;

    [SerializeField]
    private float m_RotationSpeed = 10;
    #endregion

    #region Main Updates
    private void LateUpdate()
    {
        Vector3 newPos = m_PlayerTransforms.position + m_Offset;

        transform.position = Vector3.Slerp(transform.position, newPos, 1);

        float rotationAmount = m_RotationSpeed * Input.GetAxis("Mouse X");
        transform.RotateAround(m_PlayerTransforms.position, Vector3.up, rotationAmount);

        m_Offset = transform.position - m_PlayerTransforms.position;  
    }
    #endregion
}
