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
        force = force / 30;
        //put a limit so the force can't be too high so that it doesn't fall back through the plane
        rb.AddForce(Vector3.up * force, ForceMode.Impulse);


    }

}
