using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Cannon : MonoBehaviour
{
    public UnityEvent shotTaken;
    public float rotationSpeed = 30f;
    private bool controlEnabled = true;
    private bool readyFire = true;

    void Update()
    {
        if (controlEnabled) CannonRotation();

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && readyFire && controlEnabled) Shoot();
    }

    void CannonRotation()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if ((transform.localEulerAngles.z < 82 && transform.localEulerAngles.z >= -1) || (transform.localEulerAngles.z <= 360 && transform.localEulerAngles.z >= 277))
            {
                transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            if ((transform.localEulerAngles.z <= 360 && transform.localEulerAngles.z > 278) || (transform.localEulerAngles.z <= 83 && transform.localEulerAngles.z >= -1))
            {
                transform.Rotate(Vector3.forward * -rotationSpeed * Time.deltaTime);
            }
        }
    }

    void DisableControl()
    {
        controlEnabled = false;
    }

    void EnableControl()
    {
        controlEnabled = true;
    }

    void DisableFire()
    {
        readyFire = false;
    }

    void EnableFire()
    {
        readyFire = true;
    }

    void Shoot()
    {
        shotTaken.Invoke();
    }
}
