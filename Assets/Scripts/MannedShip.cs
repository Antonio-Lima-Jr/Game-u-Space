using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MannedShip : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(Input.acceleration.x*-100, 0, Input.acceleration.y * -100);
        Debug.Log(Input.accelerationEvents.Clone());
    }
}
