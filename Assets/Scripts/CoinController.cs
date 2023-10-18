using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField] private float Speed;
  
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.RotateAroundLocal(Vector3.up, Speed * Time.deltaTime);
    }
}
