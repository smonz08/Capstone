using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RandomTimedEvent : MonoBehaviour
{
    [SerializeField] float runTime;    

    [Header("Time Intervals")]
    [Tooltip("Minimum time in seconds")]
    public float minInterval = 5f;

    [Tooltip("Maximum time in seconds")]
    public float maxInterval = 30f;

    [Header("Event")]
    public UnityEvent RandomTimedEvent_Event;

    [Tooltip("Enable to trigger the event initially")]
    public bool triggerInitially = true;

    private void Start()
    {   
        if (triggerInitially)
            TriggerEvent(); // Trigger the event initially if enabled

        // Invoke the TriggerEvent method randomly between minInterval and maxInterval
        InvokeRepeating("TriggerEvent", Random.Range(minInterval, maxInterval), Random.Range(minInterval, maxInterval));
    }

    private void TriggerEvent()
    {
        if (Time.time < runTime){
        // Your event or code to trigger goes here
        RandomTimedEvent_Event.Invoke();
        } else {}
    }
}