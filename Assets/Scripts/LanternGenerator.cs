using UnityEngine;
using System.Collections;

public class LanternGenerator : MonoBehaviour {

    public GameObject m_LanternPrefab;
    private GameObject m_LanternInstance;

    public int m_LanternMaxCount;
    public int m_LanternCount;

    void Start()
    {
        LaunchLantern();
    }


    public void LaunchLantern()
    {
        StartCoroutine(LanternDelay());
    }

    IEnumerator LanternDelay()
    {
        m_LanternCount = 0;
        while(m_LanternCount<m_LanternMaxCount)
        {
            m_LanternInstance = Instantiate(m_LanternPrefab, transform.position+ Random.insideUnitSphere*10
                , Quaternion.identity) as GameObject;
            m_LanternCount++;
            yield return new WaitForSeconds(Random.Range(0.3f,0.6f));
        }


    }

    void InstantiateNewLantern()
    {

    }
}
