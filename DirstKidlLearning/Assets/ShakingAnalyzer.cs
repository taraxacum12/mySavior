using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakingAnalyzer : MonoBehaviour
{
    private float lastShakeTime = -1f;
    private float startShakeTime = -1f;
    public GameObject go;

    private static float delay = 5f;
    private static float accelerometerUpdateInterval = 1.0f / 60.0f;
    private static float lowPassKernelWidthInSeconds = 1.0f;
    private static float shakeDetectionThreshold = 0.5f;

    private float lowPassFilterFactor = accelerometerUpdateInterval / lowPassKernelWidthInSeconds;
    private Vector3 lowPassValue = Vector3.zero;
    private Vector3 acceleration;
    private Vector3 deltaAcceleration;

	// Use this for initialization
	void Start()
    {
        Debug.Log("[Shake] IT'S WORK!!!");
        shakeDetectionThreshold *= shakeDetectionThreshold;
        lowPassValue = Input.acceleration;
        
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = Input.acceleration;
        lowPassValue = Vector3.Lerp(lowPassValue, acceleration, lowPassFilterFactor);
        deltaAcceleration = acceleration - lowPassValue;
        float dif = deltaAcceleration.sqrMagnitude - shakeDetectionThreshold;

        if (dif <= 0.5f || dif >= 1.2f)
            return;

        if (startShakeTime == -1 || (Time.time - startShakeTime >= delay && Time.time - lastShakeTime >= delay))
        {
            startShakeTime = Time.time;
        } else if (Time.time - startShakeTime >= delay && Time.time - lastShakeTime < delay)
        {
            // Спрашивать о помощи тут
            Debug.Log("[Shake] IT'S WORK!!!");
            startShakeTime = -1;
            GameObject.Find("MainPage").SetActive(false);
           go.SetActive(true);
        }

        lastShakeTime = Time.time;
    }
}
