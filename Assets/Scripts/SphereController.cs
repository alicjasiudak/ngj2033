using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LEGOWirelessSDK;

public class SphereController : MonoBehaviour
{   
    private Rigidbody rb;
    public ForceSensor forceSensor;
    public HubBase hub;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!hub.IsConnected)
            return;

        
    }
    public void OnForceChanged(int force)
    {
        Debug.Log($"force amount: {force}");

    }

 }
