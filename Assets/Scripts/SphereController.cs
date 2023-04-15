using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LEGOWirelessSDK;

public class SphereController : MonoBehaviour
{   
    private Rigidbody rb;
    public ForceSensor forceSensor;
    public HubBase hub;

    bool playerReady = false;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (hub.IsConnected && !playerReady || Input.GetKeyDown(KeyCode.Space) && !playerReady)
        {
            playerReady = true;
        }
            //     return;

        if (playerReady == false) { return; }

        rb.AddForce(new Vector3(1,0,0));
        // if (!hub.IsConnected)
        //     return;
        if (Input.GetKeyDown(KeyCode.Space))
        {
        onKeyClick();
        }
    }

    public void onKeyClick()
    {
        Debug.Log("force amount");
        //put a limit so the force can't be too high so that it doesn't fall back through the plane
        rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }

    public void OnForceChanged(int force)
    {
        Debug.Log($"force amount: {force}");
        force = force / 30;
        //put a limit so the force can't be too high so that it doesn't fall back through the plane
        rb.AddForce(Vector3.up * force, ForceMode.Impulse);


    }

}
