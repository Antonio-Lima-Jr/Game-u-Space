using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MannedShip : MonoBehaviour
{
    public TouchSO KnobLeft;
    public TouchSO KnobRight;
    Rigidbody rbMannedShip;
    Vector3 direction;
    public MannedShipSO mannedShip;
    public float currentspeed;
    // Update is called once per frame
    private void Start()
    {
        rbMannedShip = GetComponent<Rigidbody>();
        direction = Vector3.zero;
    }
    void Update()
    {
        direction += new Vector3(0, KnobLeft.getDelta().x * Time.deltaTime, KnobLeft.getDelta().y * Time.deltaTime );
        transform.rotation = Quaternion.Euler( direction);
        Debug.Log(KnobLeft.getDelta().y);
        if (KnobRight.getDelta().y > 0)
        {
            currentspeed += mannedShip.speed * Time.deltaTime;

            transform.position += new Vector3(currentspeed, 0, 0);
            //rbMannedShip.AddRelativeForce(Vector3.right* currentspeed);
        }
        if (KnobRight.getDelta().y < 0)
        {
            currentspeed -= mannedShip.speed * Time.deltaTime;

            transform.position += new Vector3(currentspeed, 0, 0);
            //rbMannedShip.AddRelativeForce(Vector3.right * currentspeed);
        }
        if (KnobRight.getDelta().y == 0)
        {

            transform.position += new Vector3(currentspeed, 0, 0);
            //rbMannedShip.AddRelativeForce(Vector3.right * currentspeed);
        }
    }
}
