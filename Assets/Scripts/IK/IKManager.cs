using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKManager : MonoBehaviour
{
    public Joint m_root;

    public Joint m_end;

    public GameObject m_target;

    public float m_threshold = 0.05f;

    public float m_rate = 2f;

    float CalculateSlope(Joint _joint)
    {
        float deltaThetha = 0.01f;
        float distance1 = GetDistance(m_end.transform.position, m_target.transform.position);

        _joint.Rotate(deltaThetha);

        float distance2 = GetDistance(m_end.transform.position, m_target.transform.position);

        _joint.Rotate(-deltaThetha);

        return (distance2 - distance1) / deltaThetha;
    }

    void Update()
    {
        if(GetDistance(m_end.transform.position, m_target.transform.position) > m_threshold)
        {
            Joint current = m_root;
            while(current != null)
            {
                float slope = CalculateSlope(current);
                current.Rotate(-slope * m_rate);
                current = current.GetChild(); 
            }
        }
    }

    float GetDistance(Vector3 _point1, Vector3 _point2)
    {
        return Vector3.Distance(_point1, _point2);
    }
}
