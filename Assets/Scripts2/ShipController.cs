using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public TouchSO knobRight, knobLeft;
    public float forwardSpeed = 25f, strafeSpeed = 7.5f;
    private float activeForwardSpeed, activeStrafeSpeed;
    public float forwardAceleration = 2.5f, strafeAceleration = 2f;

    public float lookRateSpeed = 0.01f;
    private Vector2 lookInput, screenCenter, mouseDistance;

    // Start is called before the first frame update
    void Start()
    {
        screenCenter.x = Screen.width * .5f;
        screenCenter.y = Screen.height * .5f;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        lookInput.y = knobLeft.getDirection().x;
        lookInput.x = knobLeft.getDirection().y;

        mouseDistance.x = (lookInput.x - screenCenter.x) / screenCenter.x;
        mouseDistance.y = (lookInput.y - screenCenter.y) / screenCenter.y;

        Debug.Log(lookInput);
        Debug.Log(screenCenter);
        */
        transform.Rotate(0f, knobLeft.getDelta().x * lookRateSpeed * Time.deltaTime, knobLeft.getDelta().y * lookRateSpeed * Time.deltaTime, Space.Self);

        activeForwardSpeed = Mathf.Lerp(activeForwardSpeed , knobRight.getDelta().normalized.y * forwardSpeed, forwardAceleration * Time.deltaTime);
        activeStrafeSpeed = Mathf.Lerp(activeStrafeSpeed, knobRight.getDelta().normalized.x * strafeSpeed, strafeAceleration * Time.deltaTime);
        

        transform.position += transform.right * activeForwardSpeed * Time.deltaTime;
        transform.position += transform.forward * -activeStrafeSpeed * Time.deltaTime;

    }
}
