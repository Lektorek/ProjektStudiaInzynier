using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightController : MonoBehaviour
{
    [SerializeField] private GameObject theBall;
    private Transform btrans;
    // Update is called once per frame
    void FixedUpdate()
    {
        btrans = theBall.transform;
        transform.LookAt(btrans);
        Vector3 lightPosition = new Vector3(btrans.position.x, 7.44f, btrans.position.z);
        transform.localPosition = lightPosition;
    }
}
