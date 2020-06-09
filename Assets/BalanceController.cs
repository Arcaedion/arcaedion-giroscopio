using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalanceController : MonoBehaviour
{
    private Gyroscope _gyroscope;
    void Start()
    {
        _gyroscope = Input.gyro;
        _gyroscope.enabled = true;
    }

    void Update()
    {
        // attitude
        var attX = _gyroscope.attitude.x * (-90);
        var attY = _gyroscope.attitude.y * (-90);
        
        transform.rotation = Quaternion.Euler(attX, 0, attY);
    }
}
