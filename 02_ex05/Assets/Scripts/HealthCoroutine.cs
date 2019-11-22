using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCoroutine : MonoBehaviour
{
    private IEnumerator healthCheck;
    [SerializeField]
    private float health;

    // Start is called before the first frame update
    void Start()
    {
        health = 24.0f;
        healthCheck = HealthCheck();
        StartCoroutine(healthCheck);
        // StopCoroutine(healthCheck);
    }

    private IEnumerator HealthCheck()
    {
        WaitForSeconds wfs = new WaitForSeconds(5);

        while (true)
        {
            yield return wfs;
            if (health < 25.0f) Debug.Log("Low Health!");
        }
    }
}
