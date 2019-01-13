using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {

    public Transform doorKey;
    [SerializeField]
    private Animator m_doorAnimator;
    private Transform m_transform;
    public float activateDistance = 2.0f;

    private bool m_open = false;

    private void Start()
    {
        m_transform = gameObject.transform;
        if (m_doorAnimator == null) m_doorAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(m_transform && m_doorAnimator && doorKey)
        {
            if(Vector3.Distance(doorKey.position, m_transform.position) < activateDistance)
            {
                if(m_open == false)
                {
                    m_doorAnimator.SetBool("open", true);
                    m_open = true;
                }
            }
        }
    }
}
